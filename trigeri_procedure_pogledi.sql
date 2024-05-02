
drop procedure clanska_karta;

delimiter $$
create procedure clanska_karta(in pDatumUclanjivanja date, in pDatumIsclanjivanja varchar(10), in pOsobaId int)
begin
    insert into clanska_karta(DatumUclanjivanja, DatumIsclanjivanja, OsobaId) values (pDatumUclanjivanja, pDatumIsclanjivanja, pOsobaId);
end$$
delimiter ;

drop procedure uclanjivanje_clana;

delimiter $$
create procedure uclanjivanje_clana(in pOsobaId int, in pLovackoUdruzenjeId int, in pGrupaId int)
begin
	set @idGrupe = (select grupa.GrupaId from grupa where grupa.GrupaId=pGrupaId);
    if @idGrupe is not null
    then
		set @idSekcije = (select grupa.SekcijaId from grupa where grupa.GrupaId=@idGrupe);
        
        if @idSekcije is not null
        then
			set @idUdruzenja = (select sekcija.LovackoUdruzenjeId from sekcija where sekcija.SekcijaId=@idSekcije);
            
            if @idUdruzenja = pLovackoUdruzenjeId
            then
				insert into lovacko_udruzenje_clana(OsobaId, LovackoUdruzenjeId, GrupaId) values(pOsobaId, pLovackoUdruzenjeId, pGrupaId);
            end if;
        end if;
    end if;
      
end $$
delimiter ;

drop trigger povecaj_broj_u_grupi_i_sekciji;

delimiter $$
create trigger povecaj_broj_u_grupi_i_sekciji after insert on lovacko_udruzenje_clana
for each row
begin
	update grupa set grupa.BrojClanovaUGrupi=grupa.BrojClanovaUGrupi+1 where grupa.GrupaId=new.GrupaId;
    update sekcija set sekcija.BrojClanovaUSekciji=sekcija.BrojClanovaUSekciji+1 where sekcija.LovackoUdruzenjeId=new.LovackoUdruzenjeId;
end $$
delimiter ;

drop procedure dodaj_clana;

delimiter $$
create procedure dodaj_clana(in pJMB varchar(13), in pBrojLK varchar(8), in pPrezime varchar(50), in pIme varchar(50), in pAdresa varchar(80), in pTelefon varchar(45), in pStatus varchar(10))
begin
		call dodaj_osobu(pJMB, pBrojLK, pPrezime, pIme, pAdresa, pTelefon);
        set @idOsobe = (select OsobaId from osoba where JMB=pJMB);
        insert into clan(OsobaId, Status) values (@idOsobe, pStatus);
end $$
delimiter ;

drop procedure dodaj_osobu;

delimiter $$
create procedure dodaj_osobu(in pJMB varchar(13), in pBrojLK varchar(8), in pPrezime varchar(50), in pIme varchar(50), in pAdresa varchar(80), in pTelefon varchar(45))
begin
	insert into osoba(JMB, BrojLicneKarte, Prezime, Ime, Adresa, Telefon) values (pJMB, pBrojLK, pPrezime, pIme, pAdresa, pTelefon);
end$$
delimiter ;

drop procedure dodaj_admina;

delimiter $$

create procedure dodaj_admina(in pId int, in pKorisnickoIme varchar(50), in pLozinka varchar(50))
begin
		insert into bp_lovacki_savez.administrator(KorisnickoIme, Lozinka, OsobaId) values (pKorisnickoIme, pLozinka, pId);
end $$
delimiter ;

drop procedure azuriraj_osobu_i_clana;

delimiter $$
create procedure azuriraj_osobu_i_clana(in pBrojLK varchar(8), in pPrezime varchar(50), in pIme varchar(50), in pAdresa varchar(80), in pTelefon varchar(45), in pStatus varchar(10), in pJmb varchar(13))
begin
	update osoba o set o.BrojLicneKarte=pBrojLK, o.Prezime=pPrezime, o.Ime=pIme, o.Adresa=pAdresa, o.Telefon=pTelefon where o.JMB=pJmb;
    set @idOsobe = (select OsobaId from osoba where JMB=pJmb);
    update clan set Status=pStatus where OsobaId=@idOsobe;
end $$
delimiter ;


drop procedure azuriraj_clana;

delimiter $$
create procedure azuriraj_clana(in pOsobaId int, in pStatus varchar(10))
begin
	update clan set Status=pStatus where OsobaId=pOsobaId;
end$$
delimiter ;

drop trigger promjeni_status_clana;

delimiter $$
create trigger promjeni_status_clana after update on clanska_karta
for each row
begin
	update clan set clan.Status="neaktivan" where clan.OsobaId=old.OsobaId;
end$$
delimiter ;

drop procedure ukloni_clana_iz_udruzenja;

delimiter $$
create procedure ukloni_clana_iz_udruzenja(in pOsobaId int, in pLovackoUdruzenjeId int, in pGrupaId int)
begin
	set @idGrupe = (select grupa.GrupaId from grupa where grupa.GrupaId=pGrupaId);
    if @idGrupe is not null
    then
		set @idSekcije = (select grupa.SekcijaId from grupa where grupa.GrupaId=@idGrupe);
        
        if @idSekcije is not null
        then
			set @idUdruzenja = (select sekcija.LovackoUdruzenjeId from sekcija where sekcija.SekcijaId=@idSekcije);
            
            if @idUdruzenja = pLovackoUdruzenjeId
            then
				delete from lovacko_udruzenje_clana where lovacko_udruzenje_clana.OsobaId=pOsobaId;
            end if;
        end if;
    end if;
end$$
delimiter ;

drop trigger umanji_broj_u_grupi_i_sekciji;

delimiter $$
create trigger umanji_broj_u_grupi_i_sekciji after delete on lovacko_udruzenje_clana
for each row
begin
	update grupa set grupa.BrojClanovaUGrupi=grupa.BrojClanovaUGrupi-1 where grupa.GrupaId=old.GrupaId;
    update sekcija set sekcija.BrojClanovaUSekciji=sekcija.BrojClanovaUSekciji-1 where sekcija.LovackoUdruzenjeId=old.LovackoUdruzenjeId;
end$$
delimiter ;

drop trigger umanji_broj_divljaci_u_kalendaru;

delimiter $$
create trigger umanji_broj_divljaci_u_kalendaru before insert on evidencija_odstrela
for each row
begin
		set @idDivljaci = (select DivljacId from divljac where DivljacId=new.DivljacId);
        set @brojnost = (select Brojnost from lovni_kalendar_divljaci where DivljacId=@idDivljaci);
        if @brojnost > 0
        then
			update lovni_kalendar_divljaci set lovni_kalendar_divljaci.Brojnost=lovni_kalendar_divljaci.Brojnost-1 where lovni_kalendar_divljaci.DivljacId=new.DivljacId;
		
        elseif (@brojnost = 0)
        then
			SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Predviđeni broj je ispunjen';
        end if;
end$$
delimiter ;

drop procedure azuriraj_lozinku;

delimiter $$
create procedure azuriraj_lozinku(in pId int, in pLozinka varchar(50))
begin
	update administrator a set a.Lozinka=pLozinka where a.OsobaId=pId;
end$$
delimiter ;

drop procedure dodaj_novo_udruzenje;

delimiter $$
create procedure dodaj_novo_udruzenje(in pLovackoUdruzenjeNaziv varchar(45), in pBrojPoste varchar(10), in pNaziv varchar(45), in pLovackiSavezId int, in pBrojTelefona varchar(20))
begin
	set @brojPoste = (select m.BrojPoste from mjesto m where m.BrojPoste=pBrojPoste);
    if @brojPoste is null
    then
		insert into mjesto(BrojPoste, Naziv) values (pBrojPoste, pNaziv);
		insert into lovacko_udruzenje (LovackoUdruzenjeNaziv,  BrojPoste, LovackiSavezId) values (pLovackoUdruzenjeNaziv, pBrojPoste, pLovackiSavezId);
		insert into telefon_udruzenja (BrojTelefona, LovackoUdruzenjeId) values (pBrojTelefona, last_insert_id());
	
    elseif @brojPoste is not null
    then
		insert into lovacko_udruzenje (LovackoUdruzenjeNaziv, BrojPoste, LovackiSavezId) values (pLovackoUdruzenjeNaziv, pBrojPoste, pLovackiSavezId);
		insert into telefon_udruzenja (BrojTelefona, LovackoUdruzenjeId) values (pBrojTelefona, last_insert_id());
    end if;
end$$
delimiter ;

drop procedure evidentiraj_odstrel;

delimiter $$
create procedure evidentiraj_odstrel(in pDivljacId int, in pDatumOdstrela date, in pOsobaId int)
begin
	insert into evidencija_odstrela(DivljacId, OsobaId, DatumOdstrela) values (pDivljacId, pOsobaId, pDatumOdstrela);
end$$
delimiter ;


delimiter $$
create procedure dodaj_oruzje(in pFabrickiBroj varchar(5), in pVrstaOruzjaId int, pMarkaOruzjaId int, in pKalibarId int)
begin
	insert into oruzje(FabrickiBroj, VrstaOruzjaId, MarkaOruzjaId, KalibarOruzjaId) values (pFabrickiBroj, pVrstaOruzjaId, pMarkaOruzjaId, pKalibarId);
end$$
delimiter ;

drop procedure dodaj_oruzani_list;
delimiter $$
create procedure dodaj_oruzani_list(in pSerijskiBroj varchar(6), in pDatumIzdavanja date, in pRokVazenja varchar(45), in pFabrickiBroj varchar(5), in pOsobaId int)
begin
	insert into oruzani_list(SerijskiBroj, DatumIzdavanja, RokVazenja, FabrickiBroj, OsobaId) values (pSerijskiBroj, pDatumIzdavanja, pRokVazenja, pFabrickiBroj, pOsobaId);
end$$
delimiter ;


drop trigger obrisi_oruzani_list;

delimiter $$
create trigger obrisi_oruzani_list after update on clan
for each row
begin
	declare serijskiBroj char(6);
    declare fabrickiBroj varchar(5);
    declare vKraj bool default false;
    declare cSerijskiBrojevi cursor for 
    select SerijskiBroj, oruzani_list.FabrickiBroj from oruzani_list where oruzani_list.OsobaId=new.OsobaId;
    declare continue handler for not found set vKraj=true;
    
    open cSerijskiBrojevi;
    
    petlja: LOOP
		fetch cSerijskiBrojevi into serijskiBroj, fabrickiBroj;
			
        if vKraj then
			leave petlja;
		end if;
        
        delete from oruzani_list where oruzani_list.OsobaId=new.OsobaId;
		delete from oruzje where oruzje.FabrickiBroj=fabrickiBroj;
	end loop petlja;
    close cSerijskiBrojevi;
    -- set @serijskiBroj = (select group_concat(SerijskiBroj) from oruzani_list where OsobaId=new.OsobaId);
	
    
end$$
delimiter ;


-- pogledi

drop view pregled_evidencije_odstrela;

create view pregled_evidencije_odstrela
as
	select concat(o.Prezime, ', ', o.Ime) as "Član", d.Vrsta as "Divljač", ev.DatumOdstrela from evidencija_odstrela ev
    inner join clan c on ev.OsobaId=c.OsobaId
    inner join osoba o on c.OsobaId=o.OsobaId
    inner join divljac d on ev.DivljacId=d.DivljacId;
    
-- ukupan broj odstrela po clanu
drop view odstreli_clanova;

create view odstreli_clanova 
as
	select concat(o.Prezime, ' ', o.Ime) as "Član", count(ev.OsobaId) as "Broj odstrela" from evidencija_odstrela ev inner join clan c on ev.OsobaId=c.OsobaId
	inner join osoba o on c.OsobaId=o.OsobaId group by ev.OsobaId;
    
-- pregled oruzja koje clan posjeduje

create view pregled_oruzja_clana
as
	SELECT concat(o.Prezime, ' ', o.Ime, '(', o.JMB, ')') as "Član", w.FabrickiBroj, 
	concat( m.MarkaOruzjaNaziv, ' ', k.Kalibar, ', ', vo.VrstaOruzjaNaziv) as "Oružje" from 
	((((((bp_lovacko_udruzenje.oruzani_list ol inner join bp_lovacko_udruzenje.clan c on ol.OsobaId=c.OsobaId)
	inner join bp_lovacko_udruzenje.osoba o on c.OsobaId=o.OsobaId)inner join bp_lovacko_udruzenje.oruzje w 
	on ol.FabrickiBroj=w.FabrickiBroj)inner join bp_lovacko_udruzenje.vrsta_oruzja vo 
	on w.VrstaOruzjaId=vo.VrstaOruzjaId)inner join bp_lovacko_udruzenje.marka_oruzja m
	on w.MarkaOruzjaId=m.MarkaOruzjaId)inner join bp_lovacko_udruzenje.kalibar_oruzja k
	on w.KalibarOruzjaId=k.KalibarOruzjaId);

drop view pregled_udruzenja;    

create view pregled_udruzenja
as
	select u.LovackoUdruzenjeNaziv as "Naziv udruzenja", m.Naziv, sum(s.BrojClanovaUSekciji) as "Ukupan broj clanova" from lovacki_savez ls 
	inner join lovacko_udruzenje u on ls.LovackiSavezId=u.LovackiSavezId
	inner join mjesto m on u.BrojPoste=m.BrojPoste
    inner join sekcija s on s.LovackoUdruzenjeId=u.LovackoUdruzenjeId group by u.LovackoUdruzenjeId;
    
drop view pregled_grupa_po_sekciji;

create view pregled_grupa_po_sekciji as
select s.Naziv as "Naziv sekcije", count(g.GrupaId) as "Broj grupa", s.BrojClanovaUSekciji from grupa g
inner join sekcija s on g.SekcijaId=s.SekcijaId group by s.SekcijaId;

-- Pogled koji ce izlistati sve aktivne clanove udruzenja

delimiter $$
create procedure ispis_aktivnih_clanova(in pLovackoUdruzenjeNaziv varchar(45))
begin
	select * from aktivni_clanovi_udruzenja where LovackoUdruzenjeNaziv=pLovackoUdruzenjeNaziv;
end$$
delimiter ;


create view aktivni_clanovi_udruzenja
as
	select o.JMB, concat(o.Prezime, ' ', o.Ime) as "Clan", lu.LovackoUdruzenjeNaziv from lovacko_udruzenje_clana luc inner join clan c on luc.OsobaId=c.OsobaId
    inner join osoba o on c.OsobaId=o.OsobaId
    inner join lovacko_udruzenje lu on luc.LovackoUdruzenjeId=lu.LovackoUdruzenjeId;
