all: mono

mono: swf-treeview.cs
	mcs -g swf-treeview.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-treeview.cs
	csc swf-treeview.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-treeview.exe -r -f
	rm -f swf-treeview.exe.mdb