all: mono

mono: swf-horizontalscrollbar.cs swf-scrollbars-resize.cs
	mcs swf-horizontalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-scrollbars-resize.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-horizontalscrollbar.cs swf-scrollbars-resize.cs
	csc swf-horizontalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-scrollbars-resize.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-horizontalscrollbar.exe -r -f
	rm swf-scrollbars-resize.exe -r -f
