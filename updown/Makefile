all: mono

mono: swf-numericupdown.cs
	mcs swf-numericupdown.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-numericupdown.cs
	csc swf-numericupdown.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-numericupdown.exe -r -f

