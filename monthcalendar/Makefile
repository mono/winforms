all: mono

mono: swf-monthcalendar.cs
	mcs swf-monthcalendar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-panels.cs
	csc swf-monthcalendar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-monthcalendar.exe -r -f
