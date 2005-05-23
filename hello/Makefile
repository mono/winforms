all: mono

mono: swf-hello.cs
	mcs swf-hello.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-hello.exe -r -f
