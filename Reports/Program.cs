// Zadání:
// Aplikace by měla sestavovat a tisknout reporty.
// Záloha reportu - kopie by se měla ukládat na disk.
// Report by měl obsahovat hlavičku, data z aktuální stav skladu a datum, čas.
// Tiskárna = console => aplikace by toto měla odesílat do tiskárny.

// Vytvořit třídy:
// 0. Definice class Report (Datová třída Report - property: header, dataCreated, body)
// 1. ReportFactory - tvorba reportu
//      1. a) HeaderReader class: Načíst hlavičku - pěknou, obyč. a ugly (nastavení parametrem)
//      1. b) DataReader class: Načíst stav skladu db
//      1. c) TimeProvider class: Nastavit (získat) aktuální datum a čas //timeProvider
// 2. Printer - vypíše report na consoli
// 3. Třída pro ukládání dat na disk - FileReportWritter
// 4. Test coverage
// 5. Refactoring -> move everything to Main
// 6. Připojit DataReader na reálnou DB
// 7. Nahradit tiskárnu uložením do DB

//TODO: Jak

using Reports;

Console.WriteLine("Hello, World!");

HeaderType headerType = HeaderType.Colleagues;
DataReader datatReader = new DataReader();
ReportFactory reportFactory = new ReportFactory(datatReader);
var report = reportFactory.CreateReport(headerType);

Printer printer = new Printer();
printer.Print(report);

var fileReportWriter = new FileReportWriter();
fileReportWriter.SaveFile(report);