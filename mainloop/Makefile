all: mono

mono: swf-mainloop.cs
	mcs swf-mainloop.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-mainloop.cs
	csc swf-mainloop.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-mainloop.exe -r -f
