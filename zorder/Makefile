all: mono

mono: swf-zorder.cs
	mcs swf-zorder.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-zorder.cs
	csc swf-zorder.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-zorder.exe -r -f
