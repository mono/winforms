all: mono

mono: swf-listboxes.cs
	mcs swf-listboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-listboxes.cs
	csc swf-listboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-listboxes.exe -r -f