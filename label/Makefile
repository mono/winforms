all: mono

mono: swf-label.cs
	mcs swf-label.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-label-images.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-label.cs
	csc swf-label.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-label-images.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-label.exe -r -f
	rm swf-label-images.exe -r -f
	