all: mono

mono:swf-listbox-ownerdraw.cs
	mcs swf-listbox-ownerdraw.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
dotnet: swf-listbox-ownerdraw.cs 
	swf-listbox-ownerdraw.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll	
clean:
	rm swf-listbox-ownerdraw.exe -r -f
	
	
	
	