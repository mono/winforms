all: mono

mono: swf-listview.cs
	mcs swf-listview.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-listview.cs
	csc swf-listview.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-listview.exe -r -f
