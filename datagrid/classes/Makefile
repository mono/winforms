all: mono

mono: DataGridTableStylesTests.cs DataGridBoolColumnTests.cs GridColumnStylesCollectionTests.cs GridTableStylesCollectionTests.cs DataGridCellTests.cs
	mcs DataGridTableStylesTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs DataGridBoolColumnTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs GridColumnStylesCollectionTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs GridTableStylesCollectionTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs DataGridTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs DataGridCellTests.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	
clean:
	rm DataGridBoolColumnTests.exe -r -f
	rm DataGridTableStylesTests.exe -r -f
	rm DataGridTests.exe -r -f
	rm GridColumnStylesCollectionTests.exe -r -f
	rm GridTableStylesCollectionTests.exe -r -f
	rm DataGridCellTests.exe -r -f
