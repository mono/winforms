all: mono

mono: swf-propertygrid.cs
	mcs swf-propertygrid.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-propertygrid.cs
	csc swf-propertygrid.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-propertygrid.exe -r -f
