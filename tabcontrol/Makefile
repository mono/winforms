all: mono

mono: swf-tabcontrol.exe swf-tabcontrol2.exe
dotnet: dotnet-tabcontrol.exe dotnet-tabcontrol2.exe

swf-tabcontrol.exe: swf-tabcontrol.cs
	mcs swf-tabcontrol.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

swf-tabcontrol2.exe: swf-tabcontrol2.cs
	mcs swf-tabcontrol2.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet-tabcontrol.exe: swf-tabcontrol.cs
	csc swf-tabcontrol.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
dotnet-tabcontrol2.exe: swf-tabcontrol2.cs
	csc swf-tabcontrol.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll


clean:
	rm swf-tabcontrol.exe -r -f
	rm swf-tabcontrol2.exe -r -f
