EXE= swf-propertygrid.exe \
     swf-propertygrid-array.exe

MDB= 

CSC=mcs

all: $(EXE)

mono:
	make all CSC=mcs

dotnet:
	make all CSC=csc

clean:
	rm -f $(EXE) $(EXE:%.exe=%.exe.mdb)

%.exe: %.cs
	$(CSC) -out:$@ -debug $< /r:System.Windows.Forms.dll /r:System.Drawing.dll

