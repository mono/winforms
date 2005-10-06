all: borders.exe

borders.exe: borders.cs
	mcs borders.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm borders.exe -r -f
