all: mono

mono: swf-panels.cs
	mcs swf-panels.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-panels.cs
	csc swf-panels.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-panels.exe -r -f
