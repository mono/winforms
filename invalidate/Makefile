all: mono

mono: swf-invalidate.cs
	mcs swf-invalidate.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-invalidate.cs
	csc swf-invalidate.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-invalidate.exe -r -f