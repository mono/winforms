all: mono

mono: swf-begininvoke.cs
	mcs swf-begininvoke.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-begininvoke.cs
	csc swf-begininvoke.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-begininvoke.exe -r -f
