all: mono

mono: swf-scrollable.cs
	mcs swf-scrollable.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-scrollable.cs
	csc swf-scrollable.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-scrollable.exe -r -f
