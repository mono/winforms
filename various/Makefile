all: mono

mono: swf-various.cs
	mcs swf-various.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-zorder.cs
	csc swf-various.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-various.exe -r -f
