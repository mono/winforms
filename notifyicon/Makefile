all: mono

mono: swf-notifyicon.cs
	mcs swf-notifyicon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-notifyicon.cs
	csc swf-notifyicon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-notifyicon.exe -r -f
