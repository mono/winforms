all: FormsTest.exe FormsMdi.exe FormsHello.exe CustomControl.exe ImageViewer.exe radiobuttons.exe

FormsTest.exe: FormsTest.cs
	mcs FormsTest.cs -r:System.Windows.Forms -r:System.Drawing

FormsMdi.exe: FormsMdi.cs
	mcs FormsMdi.cs -r:System.Windows.Forms -r:System.Drawing

FormsHello.exe: FormsHello.cs
	mcs FormsHello.cs -r:System.Windows.Forms -r:System.Drawing

CustomControl.exe: CustomControl.cs
	mcs CustomControl.cs -r:System.Windows.Forms -r:System.Drawing

ImageViewer.exe: ImageViewer.cs
	mcs ImageViewer.cs -r:System.Windows.Forms -r:System.Drawing

radiobuttons.exe: radiobuttons.cs
	mcs radiobuttons.cs -r:System.Windows.Forms -r:System.Drawing

clean: 
	rm -f FormsTest.exe
	rm -f FormsMdi.exe
	rm -f FormsHello.exe
	rm -f CustomControl.exe
	rm -f ImageViewer.exe
	rm -f radiobuttons.exe
