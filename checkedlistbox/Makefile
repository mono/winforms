all: mono

mono: swf-checkedlistboxes.cs swf-checkedlistbox-checked.cs
	mcs swf-checkedlistboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-checkedlistbox-checked.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
dotnet: swf-checkedlistboxes.cs swf-checkedlistbox-checked.cs
	csc swf-checkedlistboxes.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-checkedlistbox-checked.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
clean:
	rm swf-checkedlistboxes.exe -r -f
	rm swf-checkedlistbox-checked.exe -r -f
	
	
	