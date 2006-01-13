all: mono

mono: swf-printing.cs
	mcs -debug swf-printing.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-printing.cs
	csc swf-printing.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-printing.exe -r -f
	rm -f swf-printing.exe.mdb