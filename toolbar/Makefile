all: mono

mono: swf-toolbar.cs
	mcs -g swf-toolbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-toolbar.cs
	csc swf-toolbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-toolbar.exe -r -f
