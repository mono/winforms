all: mono

mono: swf-taborder.cs
	mcs swf-taborder.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-taborder.cs
	csc swf-taborder.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-taborder.exe -r -f
