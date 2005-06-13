all: swf-icon.exe

swf-icon.exe: swf-icon.cs
	mcs swf-icon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-icon.exe -r -f
	
