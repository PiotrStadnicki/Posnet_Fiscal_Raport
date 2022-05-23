# PL
## Użyte technologie ###
sautinsoft.document 5.5.4.14
net6.0


## Opis aplikacji
Celem aplikacji jest generowanie protokołów z odczytów drukarek fiskalnych.

Protokół jest oparty o wzór z oficjalnej strony Państwowej  "https://www.podatki.gov.pl/media/4638/protok%C3%B3%C5%82-odczytu-pami%C4%99ci-fiskalnej.pdf"  na "Protokół z odczytu zawartości pamięci fiskalnej:
Protokół z odczytu zawartości pamięci fiskalnej - to dokument, do złożenia którego zobowiązani są podatnicy w przypadku zakończenia używania kas on-line, kas z elektronicznym lub papierowym zapisem kopii z powodu zakończenia działalności gospodarczej lub pracy tych kas w trybie fiskalnym.

Raporty są pozyskiwane z drukarek Posnet Thermal 1.0 i  Posnet Thermal 2.0

Raport jest wygenerowany aplikacji posnet-archiwizer-2.0.1.171 dostępnej na https://www.posnet.com.pl/programy-uzytkowe-posnet-archiwizer i przyjmuje format *.txt


Dane w aplikacji są podzielone na biblioteki Gdzie <TKey> są Nazwy zmiennych ,a <TValue>  to lokalizacja zmiennej
Dane bazowe (na temat klienta serwisanta i firmy serwisującej Drukarkę fiskalną) są umieszczone w Folderze "BasicData" 
,,,,,,,

## Instrukcja Obsługi
  
1.  Na początku należy pozyskać raport z drukarki fiskalnej przy pomocy archiwizera

2.  na końcu raportu spisać z Książeczki i umieścić bezpośrednio pod ostatnią linią
*.Nr unikatowy
*.Nr fabryczny kasy
*.Nr ewidencyjny
*.Daty przeglądów technicznych
3.  Gotowe raporty są automatycznie generowane ze wszystkich plików tekstowych z folderu "Raporty"
  
  
 # EN
## Technologies used
sautinsoft.document 5.5.4.14
net6.0


## Description of the application
The purpose of the application is to generate protocols from readings of fiscal printers.

The protocol is based on the model from the official website of the State "https://www.podatki.gov.pl/media/4638/protok%C3%B3%C5%82-odczytu-pami%C4%99ci-fiskalnej.pdf" Protocol of reading the fiscal memory content:
Report on reading the contents of the fiscal memory - this is a document to be submitted by taxpayers in the event of ending the use of on-line cash registers, cash registers with electronic or paper copies due to the end of business activity or the operation of these cash registers in the fiscal mode.

Reports are obtained from Posnet Thermal 1.0 and Posnet Thermal 2.0 printers

The report is generated by the posnet-archiwizer-2.0.1.171 application available at https://www.posnet.com.pl/programy-uzytkowe-posnet-archiwizer and takes the * .txt format


The data in the application is divided into libraries Where <TKey> is Variable Names and <TValue> is the location of the variable
Basic data (about the customer, the service technician and the company servicing the fiscal printer) are placed in the "BasicData" Folder
,,,,,,,

## User manual
  
1. First, you need to obtain a report from a fiscal printer using an archiver

2. write down from the Booklet at the end of the report and place it directly under the last line
*. Unique number
*. Factory serial number
*.Evidence Number
*. Dates of technical inspections
3. Ready reports are automatically generated from all text files from the "Raporty" folder
