all: mono

mono: swf-sysinfo.cs
	mcs swf-sysinfo.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-sysinfo.cs
	csc swf-sysinfo.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-sysinfo.exe -r -f
