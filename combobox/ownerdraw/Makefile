all: mono

mono: swf-combobox-ownerdraw.cs
	mcs swf-combobox-ownerdraw.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-combobox-ownerdraw.cs
	csc swf-combobox-ownerdraw.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-combobox-ownerdraw.exe -r -f

