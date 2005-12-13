all: mono

mono: swf-toolwindows.cs
	mcs swf-toolwindows.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-toolwindows.cs
	csc swf-toolwindows.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-toolwindows.exe -r -f