all: mono

mono: swf-rente.cs
	mcs swf-rente.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:Accessibility.dll

dotnet: swf-zorder.cs
	csc swf-rente.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:Accessibility.dll

clean:
	rm swf-rente.exe -r -f
