all: mono

mono: swf-databinding.cs
	mcs swf-databinding.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

dotnet: swf-databinding.cs
	csc swf-databinding.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

clean:
	rm swf-databinding.exe -r -f
