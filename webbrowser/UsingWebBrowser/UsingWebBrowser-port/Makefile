
name = UsingWebBrowser
appfiles = bin/*.dll bin/*.exe bin/*.mdb
exeprogram = UsingWebBrowser.exe

TARGET=./bin/
MCS=gmcs
RESGEN=resgen
MCSFLAGS=-debug 
LIBS=

USINGWEBBROWSER_EXE=$(TARGET)/UsingWebBrowser.exe
USINGWEBBROWSER_PDB=$(TARGET)/UsingWebBrowser.exe.mdb
USINGWEBBROWSER_SRC=Properties/AssemblyInfo.cs \
	Form1.cs \
	Form1.Designer.cs \
	Program.cs \
	Sales.cs
	
USINGWEBBROWSER_RESX=Form1.resx
USINGWEBBROWSER_RES=-resource:Form1.resources

all: \
$(USINGWEBBROWSER_EXE)

$(USINGWEBBROWSER_EXE): $(USINGWEBBROWSER_SRC)
	$(RESGEN) /compile Form1.resx
	$(MCS) $(MCSFLAGS) $(LIBS) -r:System.dll -r:System.Data.dll -r:System.Drawing.dll -r:System.Windows.Forms.dll \
		-r:System.Xml.dll -target:winexe -out:$(USINGWEBBROWSER_EXE) $(USINGWEBBROWSER_RES) $(USINGWEBBROWSER_SRC)

# common targets

all:	$(USINGWEBBROWSER_EXE)

clean:
	-rm -f "$(USINGWEBBROWSER_EXE)" 2> /dev/null
	-rm -f "$(USINGWEBBROWSER_PDB)" 2> /dev/null

include ../../../rules.make

# project names as targets

UsingWebBrowser: $(USINGWEBBROWSER_EXE)

