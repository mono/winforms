all: mono

mono: swf-idle.cs
	mcs swf-idle.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-idle.cs
	csc swf-idle.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-idle.exe -r -f
