all: swf-splitter.exe

swf-splitter.exe: swf-splitter.cs
	mcs swf-splitter.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-splitter.exe -r -f
