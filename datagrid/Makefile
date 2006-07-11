all: mono

mono: swf-datagrid.exe related.exe arraylist.exe kb318581.exe gridbuttons.exe

SWF_DATAGRID_EXE_SRCS = swf-datagrid.cs swf-datagrid-realsample.cs swf-datagrid-testproperties.cs swf-datagrid-tablenav.cs swf-datagrid-styles.cs swf-datagrid-editinfo.cs swf-datagrid-relations.cs

swf-datagrid.exe:  $(SWF_DATAGRID_EXE_SRCS)
	mcs /debug swf-datagrid.cs  $(SWF_DATAGRID_EXE_SRCS) /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

gridbuttons.exe:
	mcs gridbuttons.cs -resource:buttonface.bmp,DataGridButton.buttonface.bmp -resource:buttonfacepressed.bmp,DataGridButton.buttonfacepressed.bmp -resource:fullbuttonface.bmp,DataGridButton.fullbuttonface.bmp -resource:fullbuttonfacepressed.bmp,DataGridButton.fullbuttonfacepressed.bmp -r:System.Drawing.dll -r:System.Windows.Forms.dll -r:System.Data.dll

%.exe: %.cs
	mcs /debug $< /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll

dotnet: swf-datagrid.cs	

clean:
	rm -f *.exe *.mdb
