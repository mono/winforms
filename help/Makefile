all: mono

mono: swf-help.cs
	mcs swf-help.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-help.exe -r -f
