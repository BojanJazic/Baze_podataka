insert into `LOVACKI_SAVEZ` (LovackiSavezNaziv, LovackiSavezAdresa) values ("Lovački savez Republike Srpske", "Ulica Starine Novaka 24, Bijeljina");

insert into `TELEFON_SAVEZA` (BrojTelefona, LovackiSavezId) values ("055/243-400", 1);

insert into `MJESTO` (BrojPoste, Naziv) values ("76300", "Bijeljina");
insert into `MJESTO` (BrojPoste, Naziv) values ("78101", "Banja Luka");

insert into `LOVACKO_UDRUZENJE` (LovackoUdruzenjeNaziv, BrojPoste, LovackiSavezId) values ("Lovačko udruženje Zmijanje", "78101", 1);
insert into `LOVACKO_UDRUZENJE` (LovackoUdruzenjeNaziv, BrojPoste, LovackiSavezId) values ("Lovačko udruženje Gornje Crnjelovo", "76300", 1);

insert into `TELEFON_UDRUZENJA` (BrojTelefona, LovackoUdruzenjeId) values ("051/200-000", 1);

insert into `OSOBA` (JMB, BrojLicneKarte, Prezime, Ime, Adresa, Telefon) values ("1003999162528", "MMK001JJ", "Petrovic", "Petar", "Patre 5", "051222222");
insert into `OSOBA` (JMB, BrojLicneKarte, Prezime, Ime, Adresa, Telefon) values ("2112999162528", "LLK001JJ", "Markovic", "Marko", "Patre 6", "051223322");
insert into `OSOBA` (JMB, BrojLicneKarte, Prezime, Ime, Adresa, Telefon) values ("1210999162528", "NNK001JJ", "Nikolic", "Nikola", "Majke Jugovica 5", "051222000");

insert into `ADMINISTRATOR`(KorisnickoIme, Lozinka, OsobaId) values ("admin", "admin", 1);

insert into `SEKCIJA` (Naziv, BrojClanovaUSekciji, LovackoUdruzenjeId) values ("Sekcija 1", 2, 1);
insert into `SEKCIJA` (Naziv, BrojClanovaUSekciji, LovackoUdruzenjeId) values ("Sekcija 2", 25, 1);
insert into `SEKCIJA` (Naziv, BrojClanovaUSekciji, LovackoUdruzenjeId) values ("Sekcija 3", 30, 2);

insert into `GRUPA` (Naziv, BrojClanovaUGrupi, SekcijaId) values("Grupa 1", 1, 1);
insert into `GRUPA` (Naziv, BrojClanovaUGrupi, SekcijaId) values("Grupa 2", 1, 1);
insert into `GRUPA` (Naziv, BrojClanovaUGrupi, SekcijaId) values("Grupa 1", 12, 2);
insert into `GRUPA` (Naziv, BrojClanovaUGrupi, SekcijaId) values("Grupa 2", 13, 2);

insert into `CLAN` (OsobaId, Status) values (1, "aktivan");
insert into `CLAN` (OsobaId, Status) values (2, "aktivan");
insert into `CLAN` (OsobaId, Status) values (3, "aktivan");

insert into `LOVACKO_UDRUZENJE_CLANA` (OsobaId, LovackoUdruzenjeId, GrupaId) values (2, 1, 1);
insert into `LOVACKO_UDRUZENJE_CLANA` (OsobaId, LovackoUdruzenjeId, GrupaId) values (3, 1, 2);

insert into `CLANSKA_KARTA` (DatumUclanjivanja, DatumIsclanjivanja, OsobaId) values('2010-5-22', null, 2);
insert into `CLANSKA_KARTA` (DatumUclanjivanja, DatumIsclanjivanja, OsobaId) values('2010-8-29', null, 3);

insert into `KALIBAR_ORUZJA` (Kalibar) values ("16");
insert into `KALIBAR_ORUZJA` (Kalibar) values ("7mm rem mag");

insert into `VRSTA_ORUZJA` (VrstaOruzjaNaziv) values ("Puška sa neolučenim cijevima");
insert into `VRSTA_ORUZJA` (VrstaOruzjaNaziv) values ("Puška sa olučenim cijevima");

insert into `MARKA_ORUZJA` (MarkaOruzjaNaziv) values ("USSR");
insert into `MARKA_ORUZJA` (MarkaOruzjaNaziv) values ("Zastava M70");

insert into `ORUZJE` (FabrickiBroj, VrstaOruzjaId, MarkaOruzjaId, KalibarOruzjaId) values ("W0001", 1, 1, 1);
insert into `ORUZJE` (FabrickiBroj, VrstaOruzjaId, MarkaOruzjaId, KalibarOruzjaId) values ("W0002", 2, 2, 2);

insert into `ORUZANI_LIST` (SerijskiBroj, DatumIzdavanja, RokVazenja, FabrickiBroj, OsobaId) values("OL0001",  '2022-10-10', "trajno", "W0001", 2);
insert into `ORUZANI_LIST` (SerijskiBroj, DatumIzdavanja, RokVazenja, FabrickiBroj, OsobaId) values("OL0002",  '2022-11-23', "trajno", "W0002", 3);

insert into `LOVNI_KALENDAR` (DatumPocetka, DatumZavrsetka) values ('2022-10-02', '2023-1-15');

insert into `DIVLJAC` (Vrsta) values ("Zec");
insert into `DIVLJAC` (Vrsta) values ("Lisica");
insert into `DIVLJAC` (Vrsta) values ("Vuk");

insert into `LOVNI_KALENDAR_DIVLJACI` (DivljacId, KalendarLovaId, Brojnost) values (1, 1, 5);
insert into `LOVNI_KALENDAR_DIVLJACI` (DivljacId, KalendarLovaId, Brojnost) values (2, 1, 15);