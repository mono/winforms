all: swf-cursor.exe

swf-cursor.exe: swf-cursor.cs
	mcs swf-cursor.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-cursor.exe -r -f
