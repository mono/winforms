all: mono

mono: swf-verticalscrollbar.cs swf-scrollbar-events.cs
	mcs swf-verticalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-scrollbar-events.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-verticalscrollbar.cs swf-scrollbar-events.cs
	csc swf-verticalscrollbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-scrollbar-events.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-verticalscrollbar.exe -r -f
	rm swf-scrollbar-events.exe -r -f	
