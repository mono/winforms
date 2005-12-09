all: exception.exe

exception.exe: exception.cs
	mcs exception.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: exception.cs
	csc exception.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm exception.exe -r -f
