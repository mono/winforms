all: mono

mono: swf-simple-binding.cs
	mcs swf-simple-binding.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

dotnet: swf-simple-binding.cs
	csc swf-simple-binding.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

clean:
	rm swf-simple-binding.exe -r -f
