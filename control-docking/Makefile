all: mono

mono: swf-dock.cs
	mcs swf-dock.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-dock.cs
	csc swf-dock.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-dock.exe -r -f
