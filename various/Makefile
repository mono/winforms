all: mono

mono: swf-various.cs
	mcs swf-various.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:Accessibility.dll

dotnet: swf-zorder.cs
	csc swf-various.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:Accessibility.dll

clean:
	rm swf-various.exe -r -f
