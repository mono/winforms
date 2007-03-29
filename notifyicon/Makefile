all: mono

mono: swf-notifyicon.cs
	mcs swf-notifyicon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	gmcs swf-balloon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-notifyicon.cs
	csc swf-notifyicon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-balloon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-notifyicon.exe -r -f
	rm swf-balloon.exe -r -f
