all: mono

mono: swf-transparency.cs
	mcs -debug swf-transparency.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-transparency.cs
	csc swf-transparency.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-transparency.exe -r -f
	rm -f swf-transparency.exe.mdb