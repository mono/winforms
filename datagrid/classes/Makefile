all: mono

mono: DataGridTableStylesTests.cs DataGridBoolColumnTests.cs GridColumnStylesCollectionTests.cs GridTableStylesCollectionTests.cs
	mcs DataGridTableStylesTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs DataGridBoolColumnTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs GridColumnStylesCollectionTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs GridTableStylesCollectionTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-datagrid.exe -r -f
