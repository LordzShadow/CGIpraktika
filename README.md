# CGIpraktika

## Dokumentatsioon

Projektiga läks aega umbes 14 tundi kokku.  
Alguses, kui sain kätte ülesande, uurisin, kuidas töötab ASP .NET MVC, sest polnud seda kunagi varem kasutanud.  
Küll olin ise teinud PHP-s Routing süsteemi, nii et enamus osast oli tuttav. C#-i polnud ka varem kasutanud, aga  
see on väga Java sarnane, nii et polnud keeruline koodi kirjutada. Alguses võtsin ette MVC näidisprogrammi ning  
uurisin, kuidas asjad seal täpselt töötavad. Projekti ehitasingi näidisprojekti peale(Ise tegelesingi ainult  
kontrollerite, mudelite, service-itega Back-end poolel). Back-endis sai kiiresti tehtud mudelid ja kontrollerid ning  
sai hakata kirjutama front-endi. Front-endis kasutasin Bootstrapi(kasutati juba näidisprojektis), JQueryt ja Vue.js-i.  
Nendest olin varem kasutanud JQueryt ning lugenud olin teiste kohta. CSS-i ise ei kirjutanudki, sest kõik vajalik oli  
Bootstrapis olemas ning ei hakanud kujundust muutma. Vue.js-iga oli mitmeid probleeme, aga alati leidis internetist vastuse.

### Arusaamatused:
- Ei saanud aru, kuidas ja miks peaks looma Repository klassi, ning tegin enamus loogikast service klassis.
- Ülesande püstituses ei olnud öeldud, kuidas peaks täpselt Category mudelit kasutama. Tegin selle jaoks API-sse meetodi,  
  millega saab kätte katergooriad ja javascriptis ühendasin kategooriad filmidega.
- Ma ei kasutanud id järgi otsimist, sest ei näinud sellel praeguse rakenduse juures mõtet, aga implementeerisin API-sse meetodid ikkagi  
  Minu rakendus töötab praegu nii, et filmide data saadakse GET requestiga ning hiljem, kui on vaja eraldi infot, on see juba json-stiilis objektis olemas.


### Mujalt saadud koodijupid

Eriti pikki kopeeritud koodijuppe ei ole(Kommentaarid on failides olemas), site.js failis on mõned. Mainin ära ka siin, et kasutasin autocomplete  
jaoks teise inimese loodud vue.js komponenti(https://autocomplete.trevoreyre.com/#/vue-component).
