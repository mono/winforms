all: mono

mono: swf-timers.cs
	mcs swf-timers.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-timers.cs
	csc swf-timers.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-timers.exe -r -f
