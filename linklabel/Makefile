all: mono

mono: swf-linklabels.cs
	mcs swf-linklabels.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-linklabels.cs
	csc swf-linklabels.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-linklabels.exe -r -f
