all: mono

mono: swf-horizontalscrollbar.cs
	mcs swf-horizontalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-horizontalscrollbar.cs
	csc swf-horizontalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-horizontalscrollbar.exe -r -f
