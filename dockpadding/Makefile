all: dockpadding.exe

dockpadding.exe: dockpadding.cs
	mcs -debug dockpadding.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm dockpadding.exe -r -f
