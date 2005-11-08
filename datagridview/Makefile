
ifeq ($(v2), yes)
COMPILER=/home/pedro/.local/bin/gmcs
REFERENCES=/r:System.Drawing.dll /r:System.Windows.Forms.dll /r:System.Data.dll
else
COMPILER=mcs
REFERENCES=/r:DataGridView.dll /r:System.Drawing.dll /r:System.Windows.Forms.dll /r:System.Data.dll
endif

OBJECTS=Test.exe SimpleTest.exe AdvancedBorderStyleSample.exe CellStyleSample.exe BindingTest.exe BindingDataTableTest.exe BindingDataTableTest2.exe

all: $(OBJECTS)

%.exe: %.cs
	$(COMPILER) /debug+ /target:exe /out:$@ $< $(REFERENCES)

Test.exe: Test.cs
	$(COMPILER) /debug+ /target:exe /out:Test.exe $(REFERENCES) Test.cs

BindingTest.exe: BindingTest.cs
	$(COMPILER) /debug+ /target:exe /out:BindingTest.exe $(REFERENCES) BindingTest.cs

SimpleTest.exe: SimpleTest.cs
	$(COMPILER) /debug+ /target:exe /out:SimpleTest.exe $(REFERENCES) SimpleTest.cs

AdvancedBorderStyleSample.exe: AdvancedBorderStyleSample.cs
	$(COMPILER) /debug+ /target:exe /out:AdvancedBorderStyleSample.exe $(REFERENCES) AdvancedBorderStyleSample.cs

CellStyleSample.exe: CellStyleSample.cs
	$(COMPILER) /debug+ /target:exe /out:CellStyleSample.exe $(REFERENCES) CellStyleSample.cs

clean:
	for i in $(OBJECTS); do rm -f $$i $$i.mdb; done
