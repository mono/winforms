all: mono

mono: swf-setpos.cs
	mcs swf-setpos.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-setpos.cs
	csc swf-setpos.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-setpos.exe -r -f