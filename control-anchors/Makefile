all: mono

mono: swf-anchors.cs
	mcs swf-anchors.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-anchors.cs
	csc swf-anchors.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-anchors.exe -r -f
