all: mono

mono: swf-mdi.cs
	mcs -g swf-mdi.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-treeview.cs
	csc swf-mdi.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-mdi.exe -r -f
