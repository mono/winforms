all: swf-begininvoke.exe

swf-begininvoke.exe: swf-begininvoke.cs
	mcs -debug swf-begininvoke.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-begininvoke.exe -r -f
