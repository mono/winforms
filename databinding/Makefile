all: mono

mono: swf-databinding.cs swf-databinding-listbox.cs
	mcs swf-databinding.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll
	mcs swf-databinding-listbox.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

dotnet: swf-databinding.cs swf-databinding-listbox.cs
	csc swf-databinding.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll
	csc swf-databinding-listbox.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

clean:
	rm swf-databinding.exe -r -f
	rm swf-databinding-listbox.exe -r -f
	
