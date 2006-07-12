all: mono

mono: swf-toolbar.exe layout-toolbar.exe

dotnet: swf-toolbar.cs
	csc swf-toolbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

swf-toolbar.exe: swf-toolbar.cs
	mcs swf-toolbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

layout-toolbar.exe: layout-toolbar.cs
	mcs layout-toolbar.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm *.exe -r -f
