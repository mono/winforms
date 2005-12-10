all: events.exe

events.exe: events.cs
	mcs -debug events.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

clean:
	rm events.exe -r -f
