all: mono

mono: swf-mainmenu.cs
	mcs swf-mainmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-mainmenu.cs
	csc swf-mainmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-mainmenu.exe -r -f
