all: mono

mono: swf-cursor.cs
	mcs swf-cursor.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-cursor.cs
	csc swf-cursor.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-cursor.exe -r -f
