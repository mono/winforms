all: mono

mono: swf-colordialog.cs
	mcs swf-colordialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-colordialog.cs
	csc swf-colordialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-colordialog.exe -r -f
