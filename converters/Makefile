all: mono

mono: converters.cs
	mcs converters.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: converters.cs
	csc converters.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm converters.exe -r -f
