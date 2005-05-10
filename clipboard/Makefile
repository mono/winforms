all: mono

mono: clipboard.cs
	mcs -debug clipboard.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm clipboard.exe -r -f
