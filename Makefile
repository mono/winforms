SUBDIRS = \
	button checkbox control-anchors control-docking groupbox \
	label listbox listview panel radiobutton textbox combobox \
	mainmenu progressbar linklabel databinding \
        horizontalscrollbar verticalscrollbar monthcalendar 

all: 
	for i in $(SUBDIRS); do (cd $$i; make); done

clean:
	for i in $(SUBDIRS); do (cd $$i;rm *.exe -f); done

