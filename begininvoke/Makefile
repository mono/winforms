all: net_1_1

net_1_1: swf-begininvoke.cs swf-cas-begininvoke.cs
	mcs -debug swf-begininvoke.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll
	mcs -debug swf-cas-begininvoke.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

net_2_0: swf-begininvoke.cs swf-cas-begininvoke.cs
	gmcs -debug swf-begininvoke.cs /out:swf-begininvoke2.exe /r:System.Windows.Forms.dll /r:System.Drawing.dll
	gmcs -debug /out:swf-cas-begininvoke2.exe swf-cas-begininvoke.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll

clean:
	rm swf-*begininvoke.exe* -r -f
