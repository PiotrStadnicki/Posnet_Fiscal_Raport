using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using SautinSoft.Document;
using System.IO;

namespace ConsoleApp4
{
    internal class Starter
    {
        public Starter(string raportPath)
        {
            RaportPath = raportPath;
        }

        string RaportPath;
        public string[] PeriodicRaport;
        public void Raport()
        {
            var document = File.ReadAllLines(RaportPath);

            string raport = "RAPORT OKRESOWY PODSUMOWANIE";
            int starter = 0;
            bool summary = false;

            while (!summary)
            {
                summary = document[starter].Contains(raport);
                starter++;
            }

            int lengthRaport = document.Length - starter;
            string[] periodicRaport = new string[lengthRaport];
            int helper = 0;

            foreach (string line in periodicRaport)
            {

                periodicRaport[helper] = document[starter];

                starter++;

                helper++;
            }
             PeriodicRaport = periodicRaport;

        }





    }
}
