all: mono

mono: swf-updown.cs
	mcs swf-updown.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-updown.exe -r -f
