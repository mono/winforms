all: testexit.exe

testexit.exe: testexit.cs
	mcs -debug -pkg:dotnet testexit.cs

clean:
	rm -f *.exe *.mdb
