all: mono

mono: DrawFocusRectangle.cs
	mcs DrawFocusRectangle.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll	

dotnet: DrawFocusRectangle.cs
	csc DrawFocusRectangle.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
clean:
	rm DrawFocusRectangle.exe -r -f	
