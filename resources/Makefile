all: mono

mono: resources.cs
	mcs resources.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm resources.exe -r -f
