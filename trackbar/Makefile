all: mono

mono: swf-trackbars.cs
	mcs swf-trackbars.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-trackbars.cs
	csc swf-trackbars.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-trackbars.exe -r -f
