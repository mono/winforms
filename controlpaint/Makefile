all: mono

mono: DrawFocusRectangle.cs
	mcs DrawFocusRectangle.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll	

dotnet: swf-buttons.cs  swf-combobox-single.cs
	csc DrawFocusRectangle.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
clean:
	rm swf-comboboxes.exe -r -f	
