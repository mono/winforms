all: mono

mono: swf-verticalscrollbar.cs
	mcs swf-verticalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-verticalscrollbar.cs
	csc swf-verticalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-verticalscrollbar.exe -r -f
