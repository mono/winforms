all: FormsTest.exe

FormsTest.exe: FormsTest.cs
	mcs FormsTest.cs -r:System.Windows.Forms -r:System.Drawing

clean: 
	rm -f FormsTest.exe
