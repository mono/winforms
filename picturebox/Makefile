all: mono

mono: swf-picturebox.cs
	mcs swf-picturebox.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-picturebox.cs
	csc swf-picturebox.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-picturebox.exe -r -f
