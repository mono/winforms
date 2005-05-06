all: mono

mono: helpprovider.cs
	mcs helpprovider.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: helpprovider.cs
	csc helpprovider.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm helpprovider.exe -r -f
