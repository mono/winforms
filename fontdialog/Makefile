all: mono

mono: swf-fontdialog.cs
	mcs swf-fontdialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-fontdialog.cs
	csc swf-fontdialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-fontdialog.exe -r -f
