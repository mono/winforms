all: mono

mono: swf-scrolling.cs
	mcs swf-scrolling.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-scrolling.cs
	csc swf-scrolling.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-scrolling.exe -r -f