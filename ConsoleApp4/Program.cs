using System;
using System.Text.RegularExpressions;
using ConsoleApp4;
using SautinSoft.Document;






var files = Directory.GetFiles("Raporty", "*.txt");
string FilePath = (@"WordTemplate.docx");
string NewFile = (@"Gotowe/");
Console.WriteLine(files);
foreach (var file in files)
{
    
    DocumentCore dc = DocumentCore.Load(FilePath);
    var document = File.ReadAllLines(file);

    Starter Raport = new Starter(file);
     Raport.Raport();
    
    


    string FiscalPrinterOwner = string.Concat(document[1], " ", document[2], " ", document[3]);
    Holders fiscalPrinterOwner = new Holders("FiscalPrinterOwner", FilePath, FiscalPrinterOwner, dc);

    

    

    List<Dictionary<string, string>> Metchods = new List<Dictionary<string, string>>()
    {
        BasicData.GetServiceCompany(),
        BasicData.GetServiceTechnician(),
        BasicData.GetServiceClieent(),       
    };

    foreach (var dictionary in Metchods)
    {
        foreach (var item in  dictionary )

            {
              Holders Ptu = new Holders(item.Key, FilePath, item.Value, dc);
            }
    }
    foreach (var item in Value.GetValueFiscal())
    {
        Holders Ptu = new Holders(item.Key, FilePath, item.Value, dc, Raport.PeriodicRaport);
        
        
    }
    foreach (var item in Value.GetValue())
    {
        Holders Ptu = new Holders(item.Key, FilePath, item.Value, dc, Raport.PeriodicRaport);


    }

    foreach (var item in Value.GetStartValueFiscal())
    {
        Holders Ptu = new Holders(item.Key, FilePath, item.Value[0], item.Value[1], dc, Raport.PeriodicRaport);
    }
    
        
    
    string savePath = Path.ChangeExtension(NewFile, ($"{Raport.PeriodicRaport[38]}.docx"));
    dc.Save(savePath, SaveOptions.DocxDefault);
    Console.WriteLine($"raport  {Raport.PeriodicRaport[38]} generated correctly");
    }