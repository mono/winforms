all: mono

mono: swf-comboboxes.cs swf-combobox-single.cs
	mcs swf-comboboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-combobox-single.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-buttons.cs  swf-combobox-single.cs
	csc swf-comboboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-combobox-single.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-comboboxes.exe -r -f
	rm swf-combobox-single.exe -r -f
