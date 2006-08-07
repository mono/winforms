all: VisualStyleTest.exe

VisualStyleTest.exe: VisualStyleTest.cs
	gmcs VisualStyleTest.cs -r:System.Windows.Forms -r:System.Drawing

clean: 
	rm -f VisualStyleTest.exe
