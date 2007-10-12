
binprogram = $(prefix)/bin/$(name)
apppath = $(prefix)/lib/$(name)

install:
	-mkdir -p $(apppath)
	cp $(appfiles) $(apppath)
	mkdir -p $(prefix)/bin
	echo "#!/bin/sh" > $(binprogram)
	echo "exec mono --debug $(apppath)/$(exeprogram)" >> $(binprogram)
	chmod +x $(binprogram)
