all: mono

mono: swf-textboxes.cs
	mcs swf-textboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-textboxes.cs
	csc swf-textboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-textboxes.exe -r -f