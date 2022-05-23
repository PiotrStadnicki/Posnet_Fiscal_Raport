<PL>
###Użyte technologie ###
sautinsoft.document 5.5.4.14
net6.0


###Opis aplikacji###
Celem aplikacji jest generowanie protokołów z odczytów drukarek fiskalnych.

Protokół jest oparty o wzór z oficjalnej strony Państwowej  "https://www.podatki.gov.pl/media/4638/protok%C3%B3%C5%82-odczytu-pami%C4%99ci-fiskalnej.pdf"  na "Protokół z odczytu zawartości pamięci fiskalnej:
Protokół z odczytu zawartości pamięci fiskalnej - to dokument, do złożenia którego zobowiązani są podatnicy w przypadku zakończenia używania kas on-line, kas z elektronicznym lub papierowym zapisem kopii z powodu zakończenia działalności gospodarczej lub pracy tych kas w trybie fiskalnym.

Raporty są pozyskiwane z drukarek Posnet Thermal 1.0 i  Posnet Thermal 2.0

Raport jest wygenerowany aplikacji posnet-archiwizer-2.0.1.171 dostępnej na https://www.posnet.com.pl/programy-uzytkowe-posnet-archiwizer i przyjmuje format *.txt


Dane w aplikacji są podzielone na biblioteki Gdzie <TKey> są Nazwy zmiennych ,a <TValue>  to lokalizacja zmiennej
Dane bazowe (na temat klienta serwisanta i firmy serwisującej Drukarkę fiskalną) są umieszczone w Folderze "BasicData" 
,,,,,,,

### 3Instrukcja Obsługi
  
1.  )Na początku należy pozyskać raport z drukarki fiskalnej przy pomocy archiwizera

2.  na końcu raportu spisać z Książeczki i umieścić bezpośrednio pod ostatnią linią
*.Nr unikatowy
*.Nr fabryczny kasy
*.Nr ewidencyjny
*.Daty przeglądów technicznych
3.  Gotowe raporty są automatycznie generowane ze wszystkich plików tekstowych z folderu "Raporty"
