all: test

test: clean test.exe
	mono test.exe

test.exe: test.cs
	mcs test.cs -r:System.Drawing

clean:
	rm -f test.exe *_Rotate*.png

.PHONY: all test clean
