all: mono

mono: swf-filedialog.cs
	mcs swf-filedialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-filedialog.cs
	csc swf-filedialog.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-filedialog.exe -r -f
