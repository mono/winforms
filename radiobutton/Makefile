all: mono

mono: swf-radiobuttons.cs
	mcs swf-radiobuttons.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-radiobuttons.cs
	csc swf-radiobuttons.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-radiobuttons.exe -r -f