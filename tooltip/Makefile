all: mono

mono: swf-tooltip.cs
	mcs swf-tooltip.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-tooltip.cs
	csc swf-tooltip.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-tooltip.exe -r -f
