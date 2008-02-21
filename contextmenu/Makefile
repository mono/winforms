all: mono

mono: swf-basicmenu.cs swf-popups.cs contextmenu.cs
	mcs swf-basicmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-popups.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	gmcs contextmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-basicmenu.cs swf-popups.cs contextmenu.cs
	csc swf-basicmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-popups.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc contextmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-contextmenu.exe -r -f
	rm swf-popups.cs -r -f
	rm contextmenu.cs -r -f

	