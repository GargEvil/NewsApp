namespace NewsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedNews : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[News] ON
INSERT INTO [dbo].[News] ([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES (17, N'BiH kupuje lijek Remdesivir za liječenje oboljelih od korone, jedna doza košta 354 eura', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'Pomoćnik Ministarstva zdravstva FBiH Goran Čerkez potvrdio je za Klix.ba da je BiH iskazala potrebu za lijekom Remdesivir koji se koristi kao terapija za liječenje oboljelih koronavirusom.
Federacija BiH je putem evropskih zajedničkih nabavki tražila 1.100 doza, što bi prema projekcijama trebalo predstavljati mjesečnu potrošnju. Jedna doza košta 354 eura.

Očekujemo tu količinu za oktobar.Toliko je tražila i Republika Srpska.Koliko ćemo dobiti na kraju zavisi od dobavljača.Na dan dolaska gledat ćemo stopu hospitalizacije u posljednjih sedam dana u oba entiteta i na osnovu toga dogovoriti podjelu, kazao je Čerkez.

Saznajemo i da je Ministarstvo zdravstva FBiH zatražilo i dodatna sredstva za nabavku ovog lijeka u vrijednosti preko 18 miliona KM.

Tražili smo dodatna sredstva za nabavku Remdesivira u vrijednosti preko 18 miliona KM, dodao je.

Iako i dalje nijedan lijek nije proglašen kao zvaničan za liječenje koronavirusa, prema mišljenjima zdravstvenih radnika Remdesivir je pomogao u terapijama za brži oporavak.', N'2020 - 10 - 08 18:39:31', N'news.png', 1)


INSERT INTO[dbo].[News]([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES(18, N'Za gradnju vjetroelektrana na Vlašiću bit će uzet kredit od 72 miliona eura', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'Federalna vlada je podržala inicijativu da kreditnim zaduženjem kod Evropske investicijske banke (EIB) i Kreditanstalt for Wiederaufbau, Frankfurt na Majni (KfW) budu osigurana 72 miliona eura izgradnje Vjetroelektrane Vlašić.


Prihvaćena je informacija o kreditu EIB - a i KfW - a za realizaciju ovog projekta, kao osnove za vođenje pregovora te zadužena federalna ministarstva finansija i energije rudarstva i industrije, te JP Elektroprivreda BiH d.d.Sarajevo da u tim za pregovore o kreditu imenuju ovlaštene predstavnike.


Konačna odluka o zaduženju bit će donesena po okončanju pregovora s kreditorima s kojima će biti utvrđeni konačni uvjeti zaduženja po kojem će krajnji dužnik biti Elektroprivreda BiH.


Federalno ministarstvo finansija će Vladi FBiH dostaviti informaciju o pregovorima kao i tekst usaglašenih Ugovora između Bosne i Hercegovine i EIB - a i KfW - a, a današnji zaključak proslijediti Ministarstvu finansija i trezora BiH radi provođenja daljnje procedure u vezi s kreditnim zaduženjem.', N'2020 - 10 - 08 18:40:22', N'biznis.jpg', 2)

INSERT INTO[dbo].[News]([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES(19, N'Košarkašice Seattle Storma osvojile novu WNBA titulu i posvetile je Bryantu', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'Košarkašice Seattle Storma osvojile su četvrtu WNBA titulu čime su izjednačile rekord, a ovu su posvetile preminulom legendarnom NBA košarkašu Kobeu Bryantu.
Seattle Storm je pobijedio ekipu Las Vegas Aces rezultatom 92:59, a to je bila treća pobjeda u nizu koja im je donijela titulu.U posljednjoj utakmici je nabolja bila Breanna Stewart s 26 poena.


Cijela WNBA sezona je odigrana u karantinu u kampusu na Floridi zbog pandemije koronavirusa.


Košarkašica Storma Jewell Loyd je otkrila kome je nova titula posvećena.


Ovu sezonu posvećujem Kobeu Bryantu. Ovo je moja prva sezona bez njega, fokusirana sam. On je bio prva osoba koja je verovala u mene prije nego sam ušla u ligu. Ova titula je posebna, izjavila je Loyd.


Spomenula je i Breonnu Tylor kojoj je WNBA posvetila sezonu.Radi se o Afroamerikanki koju je ubila policija u njenom domu tokom racije u martu.


Kobe Bryant je poginuo u helikopterskoj nesreći u januaru.', N'2020 - 10 - 08 18:41:14', N'sport.jpg', 3)

INSERT INTO[dbo].[News]([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES(20, N'Atraktivna Georgina zagolicala maštu u Parizu, umjesto haljine nosila jaknu', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'Nije nepoznanica da atraktivna manekenka Georgina Rodriguez plijeni pažnju svojim modnim kombinacijama. Ništa drugačije nije bilo ni na reviji Louis Vuittona u Parizu, gdje se pojavila u skupocjenoj jakni ovog brenda.
Čim se pojavila na reviji, lijepa zaručnica Cristiana Ronalda ukrala je pažnju publike.Tog dana bila je u dobrom društvu, zajedno s glumicom Aliciom Vikander i teniserkom Venus Williams, piše Daily Mail.


Uz ovu jaknu koju je koristila kao haljinu i zbog koje su se mnogi pitali da li nosi išta osim veša ispod nje, Georgina je kombinovala crvene štikle i crvenu torbicu, a svojim outfitom pohvalila se i na Instagramu.


Ovo nije prvi put da je Georgina oduševila izgledom.Nedavno je na filmskom festivalu u Veneciji zasjenila brojne kolegice i kolege.Crvenim tepihom prošetala je u svilenoj roze haljini s velikim prorezom.', N'2020 - 10 - 08 18:41:59', N'magazin.jpg', 4)

INSERT INTO[dbo].[News]([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES(21, N'Istraživanja potvrdila: Kristalizirani glukozamin dugotrajno pomaže u liječenju osteoartritisa', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'U Sarajevu je na stručnom webinaru za liječnike i farmaceute, predstavljen novi lijek za liječenje osteoartritisa koljena kao i sveobuhvatne smjernice za liječenje te bolesti.
Novopredstavljeni lijek sadrži kristalizirani glukozamin sulfat i predstavlja novost na bh.tržištu kao glukozamin s kliničkim dokazanim učinkom u liječenju osteoartritisa koljena i dostupan je u svim apotekama.Kako se ističe, pozitivno djeluje na metabolizam zglobne hrskavice te može usporiti progresiju bolesti.


Osteoartitis je degenerativna i hronična bolest od koje boluje gotovo svaka druga osoba starija od 65 godina.Iako potpuno izlječenje zasada nije moguće, u Sarajevu su, u prisustvu vodećih stručnjaka, predstavljena klinička istraživanja koja su potvrdila da se sistemskom upotrebom kristaliziranog glukozamin sulfata simptomi osteoartritisa mogu znatno smanjiti i olakšati, a progresija bolesti usporiti.Tom prilikom predstavljen je novi lijek koji je prema postojećim podacima, jedini glukozamin registrovan kao lijek u Bosni i Hercegovini jer sadrži kristalizirani glukozamin sulfat i stoga osigurava učinkovitost u liječenju osteoartritisa koljena.

Prof.dr.sc.Mirsad Muftić, specijalist fizikalne medicine i rehabilitacije i subspecijalist reumatolog, održao je stručno predavanje o ulozi kristaliziranog glukozamin sulfata u liječenju osteoartritisa.Predstavio je rezultate kliničkih ispitivanja koja pokazuju zašto je jedino kristalizirani glukozamin sulfat registrovan kao lijek.


Klinička istraživanja su pokazala da jedino kristalizirani glukozamin sulfat pokazuje rezultate u liječenu osteoartritisa pa je zato i registrovan kao lijek, a ne kao dodatak prehrani. Osteoartritis je učestala bolest kojoj je potreban multimodalan način liječenja, te pacijenti moraju koristiti sve što je dostupno, od fizikalne terapije, promjene načina života do farmakoterapije. Sada je i na tržištu naše zemlje dostupan lijek koji će nedvojbeno pomoći bolesnicima, a s kojim brojne zemlje već imaju pozitivna iskustva, istakao je Prof.dr.sc.Mirsad Muftić.


Osteoartritis je izuzetno česta bolest koja se javlja uglavnom kod starijih, ali se može pojaviti i kod mlađih osoba.Najčešće oboljevaju koljena, potom kukovi, šake i kralježnica.Bol je glavna klinička manifestacija pa su ciljevi liječenja smanjenje boli, poboljšanje pokretljivosti i usporavanje progresije.Jedan od glavnih izazova u liječenju koljena zahvaćenog osteoartritisom je postizanje dugotrajnog perioda bez progresije bolesti.

Doc.dr.Dubravka Bobek, pročelnica Zavoda za fizikalnu medicinu i rehabilitaciju, KB Dubrava iz Zagreba, istakla je da je lijek u Hrvatskoj predstavljen prije tri godine i da su iskustva pacijenata pozitivna.


Hrvatske smjernice za liječenje osteoartritisa osim nefarmakoloških mjera uključuju lijekove koji primarno djeluju simtomatski ne mijenjajući tok bolesti. Međutim, recentne smjernice Evropskog društva za kliničke i ekonomske aspekte osteoporoze i osteoartritisa (engl. ESCEO)7 uključuju simptomatske sporodjelujuće lijekove koji bi moguće usporili progresiju ove bolesti, kazala je doc.dr.Dubravka Bobek.

Prof.dr.sc.Tatjana Bućma, specijalist fizikalne medicine i rehabilitacije u Zavodu za fizikalnu medicinu i rehabilitaciju Dr Miroslav Zotović, smatra da u posljednje vrijeme lijekovi igraju veliku ulogu u poboljšanju kvalitete života pacijenata.


Međunarodne smjernice za liječenje osteoarttitisa prema algoritmu predlažu kao prvi korak u liječenju nefarmakološki pristup pri čemu mislim na edukaciju, redukciju tjelesne težine i fizikalnu terapiju. Posljednjih godina, uz navedeno, kao prvi korak suvereno mjesto zauzimaju simptomatski sporodjelujući lijekovi koji učinkovito smanjuju bol i pomažu očuvanju funkcionalnosti, a tim poboljšavaju i kvalitet života pacijenata sa osteoartritisom, zaključila je prof.dr.sc.Tatjana Bućma.


Prednosti kristaliziranog glukozamin sulfata podržao je i prof.dr.Luca Gallelli sa Odjela za zdravstvene znanosti, Univerzitet Catanzaro i Jedinice za kliničku farmakologiju i farmakovigilanciju, bolnice Mater Domini u Catanzaru, Italija.


Nedavna objava Gregori i sar. objavljena u Jama, potvrđuje da kristalizirani glukozamin sulfat umanjuje bol, poboljšava funkcionalnost zgloba, usporava razvoj bolesti, a u konačnici smanjuje i potrebu za operacijama i poboljšava kvalitetu života pacijentima, istakao je.


Osteoartritis koljena pogađa više od 250 miliona ljudi širom svijeta s rastućom incidencijom, a stopa u BiH odgovara onoj u svijetu.


Zadovoljstvo nam je da je kompanija Mylan prva u BiH registrovala glukozamin kao lijek namijenjen liječenju osteoartritisa - bolesti od koje pati veliki broj pacijenata u našoj zemlji. Ovim lijekom u BiH proširujemo listu naših visokokvalitetnih lijekova, registrovanih u cijelom svijetu uključujući i Evropsku Uniju koja prilikom registracije zahtjeva izrazito visok standard kvalitete lijeka. Na taj način se trudimo da pomognemo ljudima u očuvanju zdravlja i poboljšanju kvalitete života, istakla je dr.Mirsada Pinjo, direktorica Mylana za Bosnu i Hercegovinu.


Kristalizirani glukozamin sulfat koristi se za ublažavanje simptoma blagog do umjerenog osteoartritisa koljena.Nije namijenjen za liječenje akutne nego hronične boli.Rezultati kliničkog ispitivanja pokazali su da olakšavanje simptoma, naročito boli, obično nastupa nakon dvije do tri sedmice neprekidnog liječenja.

Kristalizirani glukozamin sulfat ima pozitivan učinak na metabolizam zglobne hrskavice jer povećava sintezu proteoglikana u hrskavici i tako usporava njeno propadanje.Nadalje, kristalizirani glukozamin sulfat ima protuupalni učinak jer inhibira učinke proinflamatornog citokina IL-1¬ inhibirajući NF-kB nuklearnu transkripciju te tako i IL-1 induciranu gensku ekspresiju upalnih i degradirajućih markera.Primjenjuje se oralno, jednom dnevno i dolazi u obliku praška za oralni rastvor u dozi 1.500 mg.Dostupan je u svim apotekama bez recepta.', N'2020 - 10 - 08 18:42:48', N'lifestyle.jpg', 5)

INSERT INTO[dbo].[News]
        ([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES(22, N'Musk tvrdi da ima dovoljno satelita da pokrene vlastiti brzi bežični internet', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'Veliki plan Elona Muska da obezbijedi brzi bežični internet u udaljenim dijelovima Zemlje pomoću svojih satelita uskoro bi se mogao ostvariti.
Svemirska kompanija SpaceX lansirala je ove sedmice u orbitu seriju od 60 Starlink satelita, čime je njihov ukupan broj premašio 700, navodi Ars Technica.Musk, kao izvršni direktor SpaceX-a, tvrdi kako je to dovoljno za pokretanje beta verzije njegovog brzog interneta.

Jednom kada ovi sateliti dosegnu ciljni položaj, moći ćemo pokrenuti beta verziju interneta na sjeveru Amerike i nadamo se na jugu Kanade, napisao je Musk na Twitteru dodavši da bi njegov brzi bežični internet nakon toga moga stići i u druge zemlje, u skladu s potrebnim regulatornim odobrenjima.


Musk nije precizirao kada će sateliti doseći ciljni položaj, dok astrofizičar Jonathan McDowell iz hardvardskog Centra za astrofiziku tvrdi da se to neće desiti prije februara 2021. godine.

Musk je u aprilu rekao da će beta verziju interneta pokrenuti na jesen ove godine, ali kako se navodi u izvještaju Ars Technice, to će se desiti tokom idućih nekoliko mjeseci.


Podsjetimo da je krajnji Muskov cilj omogućiti svim ljudima na Zemlji da imaju pristup brzom bežičnom internetu, pa čak i najudaljenijim i najsiromašnijim dijelovima zemlje. To je od velikog značaja za one zemlje koje još nisu sagradile potrebnu infrastrukturu kako bi stanovnicima omogućile pristup mreži.', N'2020-10-08 18:43:39', N'scitech.png', 6)
INSERT INTO [dbo].[News] ([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES (23, N'Volvo XC100 debituje 2022. godine', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'Kompanija Volvo priprema novi flagship SUV kao zamjenu za model XC90.
Novi SUV iz kompanije Volvo nosit će oznaku XC100 te će biti direktni rival BMW-u X7 i Mercedesu GLS.

Volvo razvija novu verziju platforme za velike automobile pod nazovim SPA2.Aktuelna platforma SPA se koristi za modele 60 i 90, ali nije pogodna za veće modele od aktuelnog XC90.Ako kompanija želi parirati Mercedesovim i BMW-ovim SUV-ovima, onda XC100 mora koristiti novorazvijenu platformu.


Platforma SPA2 će biti namijenjena automobilima dužine do 5,5 metara, a treći Polestarov model, veliki potpuno električni SUV, će je koristiti u budućnosti.

Novi model se razvija pod kodnim imenom V616. Broj 6 označava prototip kao najveći model u ponudi kompanije Volvo, broj 1 znači da se radi o prvoj generaciji vozila, a druga šestica je skraćenica za karoseriju SUV-a.

XC100 će biti 30 mm duži od aktuelnog modela XC90 i nešto duži čak i od BMW-a X7. Njegova dužina će iznositi 5,2 metra, a bit će produženo i međuosovinsko rastojanje te stražnje vješanje. Time će se dobiti na prostoru za noge u drugom redu sjedišta, kao i na ukupnom prostoru u trećem redu sjedišta te u prtljažniku.


Novi XC100 će koristiti mješavinu pogonskih opcija, osnovni modeli će koristiti snažne benzinske motore s blagom hibridnom tehnologijom, a alternative će biti plug-in hibridni i potpuno električni pogon.

Ovaj model se očekuje 2022. godine.', N'2020-10-08 18:44:12', N'auto.jpg', 7)
INSERT INTO [dbo].[News] ([Id], [Title], [AuthorId], [Content], [Date], [imageUrl], [CategoryId]) VALUES (24, N'Kalifornija: Bijeli supremacist ubijen u pucnjavi sa policijom', N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'Bijeli supremacist Christopher Michael Straub (38) ubijen je u pucnjavi sa policijskim službenicima u Kaliforniji, saopćeno je iz šerifovog ureda u gradu San Luis Obispa.
Pucnjava se dogodila u četvrtak kada su službenici pokušali zaustaviti vozilo kojim je upravljao Christopher Michael Straub.Straub je izašao iz svog vozila i počeo bježati prema obližnjem groblju, navodi se u saopćenju.


Zatim se sakrio i postavio zasjedu policajcima, pucajući na njih više puta iz pištolja.Službenik Richard Ted Lehnhoff (34) pogođen je u nogu i prebačen helikopterom u lokalnu bolnicu, gdje je operiran i u stabilnom je stanju.

Straub je nastavio bježati od službenika nastojeći se vratiti do svog vozila, ali na mjesto događaja stiglo je pojačanje koje ga je presrelo.Straub je kasnije proglašen mrtvim na mjestu događaja, navodi šerifov ured, prenosi CNN.


Nakon pucnjave, policija je u Straubovom vozilu pronašla oružje, uključujući četiri puške, jednu lovačku pušku, dva pištolja, zajedno s pištoljem kojim je pucao na policajce. Pored toga, pronađeno je više stotina metaka.', N'2020-10-08 18:44:54', N'crnhronika.jpg', 8)
SET IDENTITY_INSERT [dbo].[News] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
