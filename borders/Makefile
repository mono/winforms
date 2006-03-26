all: borders.exe border3dstyle.exe

borders.exe: borders.cs
	mcs borders.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
border3dstyle.exe: border3dstyle.cs
	mcs border3dstyle.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm borders.exe border3dstyle.exe -r -f
