all: mono

mono: resources.cs
	resgen resources.resx
	mcs resources.cs -resource:resources.resources,ResourceTest.ResourceTest.resources /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm resources.exe -r -f
