all: mono

mono: swf-tabcontrol.cs
	mcs swf-tabcontrol.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-tabcontrol.cs
	csc swf-tabcontrol.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-tabcontrol.exe -r -f
