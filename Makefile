SUBDIRS = \
	button checkbox control-anchors control-docking groupbox \
	label listbox listview panel radiobutton textbox

all: 
	for i in $(SUBDIRS); do (cd $$i; make); done