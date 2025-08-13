

## Create out bucket
'''sh
aws s3 mb s3://prefixes-fun-red-1234
'''

## Create our folder
'''sh
aws s3api put-object --bucket prefixes-fun-red-1234 --key "hello/"
'''

## Create many folders
'''sh
aws s3api put-object --bucket prefixes-fun-red-1234 --key "Lorem/ipsum/dolor/sit/amet,/consectetur/adipiscing/elit./Nam/facilisis/lacus/eros,/vel/egestas/erat/convallis/at./Quisque/dapibus/mollis/neque/non/elementum./Proin/posuere/laoreet/risus,/eu/elementum/sapien/pulvinar/quis./Donec/id/egestas/ex./Donec/vitae/dictum/nisi,/eu/maximus/nunc./Integer/porttitor/facilisis/dui,/mattis/volutpat/nunc/lobortis/a./Pellentesque/laoreet/eros/a/nulla/laoreet/iaculis./Aenean/leo/nunc,/gravida/ut/enim/sed,/viverra/fermentum/lectus./Maecenas/nunc/neque,/maximus/ut/lorem/id,/iaculis/venenatis/nisl./Morbi/blandit/et/urna/et/lobortis./Praesent/sed/risus/at/mauris/consectetur/porttitor/a/at/urna./Fusce/in/enim/sed/orci/efficitur/mollis/et/sed/erat./Pellentesque/sit/amet/posuere/elit,/in/ultricies/mauris./Etiam/mollis/neque/id/ipsum/sollicitudin,/vel/vestibulum/nisi/sodales./In/sit/amet/tempus/nibh,/at/scelerisque/turpis./Vestibulum/pulvinar/luctus/ipsum,/vel/fringilla/lacus/consectetur/a./Orci/varius/natoque/penatibus/et/magnis/dis/parturient/montes,/nascetur/ridiculus/mus./Donec/cras"
'''

## Try and break the 1024 limit
'''sh
aws s3api put-object --bucket prefixes-fun-red-1234 --key "Lorem/ipsum/dolor/sit/amet,/consectetur/adipiscing/elit./Nam/facilisis/lacus/eros,/vel/egestas/erat/convallis/at./Quisque/dapibus/mollis/neque/non/elementum./Proin/posuere/laoreet/risus,/eu/elementum/sapien/pulvinar/quis./Donec/id/egestas/ex./Donec/vitae/dictum/nisi,/eu/maximus/nunc./Integer/porttitor/facilisis/dui,/mattis/volutpat/nunc/lobortis/a./Pellentesque/laoreet/eros/a/nulla/laoreet/iaculis./Aenean/leo/nunc,/gravida/ut/enim/sed,/viverra/fermentum/lectus./Maecenas/nunc/neque,/maximus/ut/lorem/id,/iaculis/venenatis/nisl./Morbi/blandit/et/urna/et/lobortis./Praesent/sed/risus/at/mauris/consectetur/porttitor/a/at/urna./Fusce/in/enim/sed/orci/efficitur/mollis/et/sed/erat./Pellentesque/sit/amet/posuere/elit,/in/ultricies/mauris./Etiam/mollis/neque/id/ipsum/sollicitudin,/vel/vestibulum/nisi/sodales./In/sit/amet/tempus/nibh,/at/scelerisque/turpis./Vestibulum/pulvinar/luctus/ipsum,/vel/fringilla/lacus/consectetur/a./Orci/varius/natoque/penatibus/et/magnis/dis/parturient/montes,/nascetur/ridiculus/mus./Donec/cras/hello.txt" --body "hello.txt"
'''