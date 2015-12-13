#Web aplikacija za vježbanje brzog pisanja

Web aplikacija koje omogućuje anonimnim korisnicima da vježbaju brzo pisanje teksta.

Web aplikacija radi na sljedeći način:
* Nakon što se klijent spoji, server nasumično izabire odlomak iz neke knjige. (računalo na kojemu je server sadrži folder 'text' koji sadrži sve odlomke, ili eventualno postoji baza podataka za svim odlomcima)
* Server vraća klijentu taj odlomak zajedno za praznim prostorom u kojem se upisuje tekst.
* Nakon toga klijent može prvo pročitati tekst, ili ga odmah početi pisati, u oba slučaja kada klijent upiše prvi znak varijabla 'start' se postavlja na vrijednost trenutačnog vremena, a svaki znak nakon prvog postavlja varijablu 'end' na trenutačno vrijeme. 
* Klijent u bilo kojem trenutku može pritisnuti na tipku 'end'.
* Nakon što je pritisnuta tipka 'end', server računa vrijeme pisanja (end - start), uspoređuje odabrani tekst sa tekstom koji je upisao klijent te računa koliki postotak riječi je točno prepisan.
* Konačno, klijent dobiva povratne informacije (postotak točnosti i brzina pisanja) te može pritisnuti tipku 'new' koja opet ponavlja cijeli postupak.

Dodatne opcije:
* Klijent može odabrati da li želi neki smisleni odlomak tesksta, ili želi nasumičnu listu riječi.
* Klijent može sa 'retry' gumbom ponovno pisati isti odlomak teksta.
* Server može za svaki odlomak pamtiti u bazi podataka najveću brzinu pisanja tog odlomka sa 100 postotnom točnošću, te to prikazivati klijentima.
* Server može periodički tražiti i unositi nove odlomke teksta.









