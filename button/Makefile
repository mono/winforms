all: mono

mono: swf-buttons.cs
	mcs swf-buttons.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-buttons.cs
	csc swf-buttons.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-buttons.exe -r -f