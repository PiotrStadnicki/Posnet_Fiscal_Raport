using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Value
    {
        


        public static Dictionary<string, int> GetValue()
        {
            return new Dictionary<string, int>
            {
                {"PtuA",13},
                {"PtuB",14},
                {"PtuC",15},
                {"PtuD",16},
                {"PtuE",21},


                {"SalePtuA",3},
                {"SalePtuB",4},
                {"SalePtuC",5},
                {"SalePtuD",6},
                {"SalePtuE",11},

                {"TotalPtuSales",22},
                {"TotalPtuAmount",21},
                {"RamRest",25},
                {"NumberOfFiscal",26},
                {"NumberOfFacture",29},
                {"NumberOfDeletedFiscal",27},
                {"ValueDeletedFiscal",28},
                {"NumberOfDeleted",1},
          };

        }
        public static Dictionary<string, int> GetValueFiscal()

        {
            return new Dictionary<string, int>
            {
                {"FactoryNumber",39},
                {"UniquenNo",38},
                {"EvidenceNumber",40},
                {"TechnicalInspectionDates",41},
            };
        }
       
        public static Dictionary<string, int[]> GetStartValueFiscal()
        {
            return new Dictionary<string, int[]>
            {
                {"DateOfFiscalization",new int[]{0,1} },
                {"LastRaport",new int[]{ 0,1}},
                {"FirstRaport",new int[]{ 0,1}},
                {"NumberLastRaport",new int[]{ 1,3}},
            };
        }
    }
}
