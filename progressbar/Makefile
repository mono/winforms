all: mono

mono: swf-progressbars.cs
	mcs swf-progressbars.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-buttons.cs
	csc swf-progressbars.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-progressbars.exe -r -f
