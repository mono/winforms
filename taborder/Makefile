all: mono

mono: swf-order.cs
	mcs swf-taborder.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-order.cs
	csc swf-taborder.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-order.exe -r -f
