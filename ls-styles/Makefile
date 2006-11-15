all: mono

mono: ls-styles.cs
	mcs ls-styles.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: ls-styles.cs
	csc ls-styles.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm ls-styles.exe -r -f