
name = standalone
appfiles = bin/*.dll bin/*.exe bin/*.mdb
exeprogram = standalone.exe

TARGET=./bin
MCS=gmcs
RESGEN=resgen
MCSFLAGS=-debug 
LIBS=

STANDALONE_EXE=$(TARGET)/standalone.exe
STANDALONE_PDB=$(TARGET)/standalone.exe.mdb
STANDALONE_SRC =  \
	DomInspector.cs \
	EventMonitor.cs \
	Main.cs \
	Page.cs
	
all: \
$(STANDALONE_EXE)

$(STANDALONE_EXE): $(STANDALONE_SRC)
	$(MCS) $(MCSFLAGS) $(LIBS) -r:System.dll -r:System.Drawing.dll -r:System.Windows.Forms.dll \
		-r:Mono.WebBrowser.dll -target:winexe -out:$(STANDALONE_EXE) $(STANDALONE_SRC)

# common targets

all:	$(STANDALONE_EXE)

clean:
	-rm -f "$(STANDALONE_EXE)" 2> /dev/null
	-rm -f "$(STANDALONE_PDB)" 2> /dev/null

include ../../rules.make

# project names as targets

standalone: $(STANDALONE_EXE)

