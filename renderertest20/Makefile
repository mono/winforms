all: RendererTest.exe

RendererTest.exe: RendererTest.cs
	gmcs RendererTest.cs -r:System.Windows.Forms -r:System.Drawing

clean: 
	rm -f RendererTest.exe
