all: mono

mono: swf-datetimepicker.cs
	mcs swf-datetimepicker.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

dotnet: swf-panels.cs
	csc swf-datetimepicker.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-datetimepicker.exe -r -f
