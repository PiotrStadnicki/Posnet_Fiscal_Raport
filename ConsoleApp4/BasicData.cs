using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class BasicData
    {
        string discalPrinterOwner;
        BasicData(string RaportPath)
        {
            discalPrinterOwner = string.Concat(RaportPath[1], " ", RaportPath[2], " ", RaportPath[3]);
        }
        public static Dictionary<string, string> GetServiceCompany()
        {
            DateTime dateTime = DateTime.Today;
            string Now = DateTime.Today.ToString("d");

            return new Dictionary<string, string>
            {
                {"ServisantCompanyName","FrirmaDreukarki"},
                {"ServisantCompanyTaxID","522-297-06-93"},
                {"ServisantCountry","Polska"},
                {"ServisantStreet","Sezamkowa "},
                {"ServisantCity","Warszawa "},
                {"ServisantProvince","mazowieckie"},
                {"ServisantAdressNo","12345"},
                {"Postcode","12-345"},
                {"ServisantTelephone","111 222 333"},
                {"Servmail","serv@fiscal.pk"},
                {"ServisantTaxpayer" ,"ProjectManager"},
                {"Now",Now},
            };
        }
        public static Dictionary<string, string> GetServiceTechnician()
        {
            return new Dictionary<string, string>
            {
                {"ServisantName","522-297-06-93"},
                {"ServisantID","22222"},
                {"ServisantIdDate","12-12-2012"},
            };
        }
        public static Dictionary<string, string> GetServiceClieent()
        {
            return new Dictionary<string, string>
            {
                {"ClientName","klijent"},         
                {"ClientTaxID","123-123-12-12"},
                {"ClientCountry","Polska"},
                {"ClientStreet","Sezamkowa "},
                {"ClientProvince","mazowieckie"},
                {"ClientAdressNo","54321"},
                {"ClientPostcode","54-3215"},
                {"ClientTelephone","333 222 111"},
                {"Clientmail","client@fiscal.pk"},
                {"ClientCity","Warszawa"},
            };
        }
        

    }
}
