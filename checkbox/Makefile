all: mono

mono: swf-checkboxes.cs
	mcs swf-checkboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-checkboxes.cs
	csc swf-checkboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-checkboxes.exe -r -f
