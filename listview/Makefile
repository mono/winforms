all: mono

mono: swf-listview.cs swf-listview-items.cs
	#mcs swf-listview.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs swf-listview-items.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs noicon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-listview.cs swf-listview-items.cs
	csc swf-listview.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc swf-listview-items.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	csc noicon.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-listview.exe -r -f
	rm swf-listview-items.exe -r -f
