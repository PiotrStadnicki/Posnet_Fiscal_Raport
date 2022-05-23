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
            
            var ServiceCompany = File.ReadAllLines("BasicData/ServiceCompany.txt");


            return new Dictionary<string, string>
            {
                {"ServisantCompanyName",ServiceCompany[1]},
                {"ServisantCompanyTaxID",ServiceCompany[3]},
                {"ServisantCountry",ServiceCompany[5]},
                {"ServisantStreet",ServiceCompany[7]},
                {"ServisantCity",ServiceCompany[9]},
                {"ServisantProvince",ServiceCompany[11]},
                {"ServisantAdressNo",ServiceCompany[13]},
                {"Postcode",ServiceCompany[15]},
                {"ServisantTelephone",ServiceCompany[17]},
                {"Servmail",ServiceCompany[19]},
                {"ServisantTaxpayer",ServiceCompany[21]},
            };
        }
        public static Dictionary<string, string> GetServiceTechnician()
        {

            var ServiceTechnician = File.ReadAllLines("BasicData/Servisant.txt");

            return new Dictionary<string, string>
            {

                {"ServisantName",ServiceTechnician[1]},
                {"ServisantID",ServiceTechnician[3]},
                {"ServisantIdDate",ServiceTechnician[5]},
            };
        }
        public static Dictionary<string, string> GetServiceClient()
        {
            var ServiceClient = File.ReadAllLines("BasicData/Client.txt");
            return new Dictionary<string, string>
            {
                {"ClientName",ServiceClient[1]},
                {"ClientTaxID",ServiceClient[3]},
                {"ClientCountry",ServiceClient[5]},
                {"ClientStreet",ServiceClient[7]},
                {"ClientProvince",ServiceClient[9]},
                {"ClientAdressNo",ServiceClient[11]},
                {"ClientPostcode",ServiceClient[13]},
                {"ClientTelephone",ServiceClient[15]},
                {"Clientmail",ServiceClient[17]},
                {"ClientCity",ServiceClient[19]},
                


            };
        }
        

    }
}
