all: mono

mono: swf-comboboxes.cs
	mcs swf-comboboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-buttons.cs
	csc swf-comboboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-comboboxes.exe -r -f
