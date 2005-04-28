all: mono

mono: wordpad.cs support.cs
	mcs wordpad.cs support.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: wordpad.cs support.cs
	csc wordpad.cs support.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm wordpad.exe -r -f
