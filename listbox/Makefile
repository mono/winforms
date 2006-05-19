all: mono

mono: swf-listboxes.cs swf-listbox-multicolumn.cs swf-listbox-selections.cs
	mcs swf-listboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-listbox-multicolumn.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-listbox-selections.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /codepage:1251

dotnet: swf-listboxes.cs swf-listbox-multicolumn.cs swf-listbox-selections.cs
	csc swf-listboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-listbox-multicolumn.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-listbox-selections.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
clean:
	rm swf-listboxes.exe -r -f
	rm swf-listbox-multicolumn.exe -r -f
	rm swf-listbox-selections.exe -r -f
	
	
