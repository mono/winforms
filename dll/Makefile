all: mono

mono: dll.cs app.cs
	mcs dll.cs /target:library /out:dll.dll /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs app.cs /out:app.exe /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:dll.dll

clean:
	rm dll.dll app.cs -r -f
