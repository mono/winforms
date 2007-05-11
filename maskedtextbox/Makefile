all: swf-maskedtextbox.exe

swf-maskedtextbox.exe: swf-maskedtextbox.cs
	gmcs swf-maskedtextbox.cs /r:System.Windows.Forms.dll,System.Drawing.dll,System.Data.dll

clean:
	rm swf-maskedtextbox.exe -r -f
