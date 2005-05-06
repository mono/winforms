all: mono

mono: errorprovider.cs
	mcs -g errorprovider.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: errorprovider.cs
	csc errorprovider.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm errorprovider.exe -r -f
