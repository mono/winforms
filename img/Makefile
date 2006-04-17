all: img.exe

img.exe: img.cs
	mcs -debug img.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm img.exe -r -f
