SUBDIRS = \
	begininvoke button checkbox checkedlistbox colordialog combobox \
	contextmenu control-anchors control-docking controlpaint cursor \
	databinding datetimepicker dll endian groupbox horizontalscrollbar \
	idle imagelist label linklabel listbox listview mainloop mainmenu \
	messagebox monthcalendar notifyicon panel picturebox printing progressbar \
	propertygrid radiobutton rente scrollrect splitter statusbar \
	sysinfo tabcontrol taborder textbox toolbar tooltip trackbar \
	transparency treeview various verticalscrollbar zorder \
	maskedtextbox

all: 
	for i in $(SUBDIRS); do (cd $$i; make); done

clean:
	for i in $(SUBDIRS); do (cd $$i;rm *.exe -f); done

