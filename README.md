#Web aplikacija za vježbanje brzog pisanja

Web aplikacija radi na sljedeći način:
* Nakon što se klijent spoji, server nasumično izabire mali odlomak iz nasumično odabrane knjige.
(računalo na kojemu je server sadrži folder 'books' koji ima niz knjiga u plain text formatu)
* Server vraća klijentu taj odlomak zajedno za praznim prostorom u kojem se upisuje tekst.
* Nakon toga klijent može prvo pročitati tekst, ili ga odmah početi pisati, u oba slučaja kada klijent
upiše prvi znak varijabla 'start' se postavlja na vrijednost trenutačnog vremena, a svaki znak nakon prvog
postavlja varijablu 'end' na trenutačno vrijeme. 
* Klijent u bilo kojem trenutku može pritisnuti na tipku 'end'.
* Nakon što je pritisnuta tipka 'end', server računa vrijeme pisanja (end - start), uspoređuje odabrani
tekst sa tekstom koji je upisao klijent te računa koliki postotak riječi je točno prepisan.
* Konačno, klijent dobiva povratne informacije (postotak točnosti i brzina pisanja) te može pritisnuti 
tipku 'retry' koja opet ponavlja cijeli postupak.












