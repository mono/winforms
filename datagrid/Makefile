all: mono

mono: swf-datagrid.cs
	mcs swf-datagrid.cs  swf-datagrid-realsample.cs swf-datagrid-testproperties.cs swf-datagrid-tablenav.cs swf-datagrid-styles.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

dotnet: swf-datagrid.cs	

clean:
	rm swf-datagrid.exe -r -f
