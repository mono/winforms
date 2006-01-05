all: modal.exe

modal.exe: modal.cs
	mcs modal.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm modal.exe -r -f
