all: mono

mono: swf-folderdialog.cs
	mcs swf-folderdialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-folderdialog.cs
	csc swf-folderdialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-folderdialog.exe -r -f
