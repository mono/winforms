all: mono

mono: swf-splitter.cs
	mcs swf-splitter.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-splitter.cs
	csc swf-splitter.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-splitter.exe -r -f
