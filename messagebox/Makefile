all: mono

mono: swf-messagebox.cs
	mcs swf-messagebox.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-messagebox.exe -r -f
