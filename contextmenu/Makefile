all: mono

mono: swf-basicmenu.cs swf-popups.cs
	mcs swf-basicmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-popups.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-basicmenu.cs swf-popups.cs
	csc swf-basicmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-popups.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-contextmenu.exe -r -f
	rm swf-popups.cs -r -f

	