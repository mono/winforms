all: mono

mono: swf-groupboxes.cs
	mcs swf-groupboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-groupboxes.cs
	csc swf-groupboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-groupboxes.exe -r -f
