all: mono

mono: swf-mainmenu.cs swf-menumerge.cs
	#mcs swf-mainmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-mainmenu-nomdi.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-menumerge.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-mainmenu.cs swf-menumerge.cs
	csc swf-mainmenu.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-mainmenu-nomdi.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-menumerge.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	

clean:
	rm swf-mainmenu.exe -r -f
	rm swf-mainmenu-nomi.exe -r -f
	rm swf-menumerge.exe -r -f
	
