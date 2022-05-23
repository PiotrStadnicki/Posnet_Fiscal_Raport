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
    public class Holders
    {

        /// <summary>
        /// Constructor used when we have defined pairs of values
        /// </summary>
        /// <param name="name">The name of the variable </param>
        /// <param name="loadPath">File path to the document template</param>
        /// <param name="value">Value placed in the file</param>
        /// <param name="dc"></param>
        public Holders(string name, string loadPath, string value , DocumentCore dc)
        {
            Name=name;
            Value = value;
            FilePath= loadPath;
            Regex regex = new Regex("{" + name + "}", RegexOptions.IgnoreCase);

            foreach (ContentRange item in dc.Content.Find(regex).Reverse())
            {
                item.Replace(value);
            }
            
        }
        int Line;
        /// <summary>
        /// Constructor used when we take end-of-line data - used most often for fiscal data
        /// </summary>
        /// <param name="name">The name of the variable</param>
        /// <param name="loadPath">File path to the document template</param>
        /// <param name="line">The line from which the data from the fiscal report are read</param>
        /// <param name="dc"></param>
        /// <param name="RaportPath">Path to the fiscal report</param>
        public Holders(string name, string loadPath,  int line, DocumentCore dc,string[] PeriodicRaport)
        {
            Name = name;
            
            FilePath = loadPath;
            Line = line;

            string periodicRaportLine = PeriodicRaport[Line];
            string[] valueLine = periodicRaportLine.Split(' ');
            string value = valueLine[valueLine.Length - 1];
            
            Holders Ptu = new Holders(Name, FilePath, value, dc);

            Regex regex = new Regex("{" + Name + "}", RegexOptions.IgnoreCase);

            foreach (ContentRange item in dc.Content.Find(regex).Reverse())
            {
                item.Replace(Value); 
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name of the variable</param>
        /// <param name="loadPath">File path to the document template</param>
        /// <param name="line">The line from which the data from the fiscal report are read</param>
        /// <param name="position">position of the value in the line</param>
        /// <param name="dc">Path to the fiscal report</param>
        /// <param name="RaportPath"></param>
        public Holders(string name, string loadPath, int line, int position, DocumentCore dc, string[] PeriodicRaport)
        {
            Name = name;

            FilePath = loadPath;
            Line = line;
            Position= position;
            string periodicRaportLine = PeriodicRaport[Line];
            string[] valueLine = periodicRaportLine.Split(' ');
            string value = valueLine[Position];
            Holders Ptu = new Holders(Name, FilePath, value, dc);

            Regex regex = new Regex("{" + Name + "}", RegexOptions.IgnoreCase);

            foreach (ContentRange item in dc.Content.Find(regex).Reverse())
            {
                item.Replace(Value);
            }
            
        }


        public string Name { get; set; }
        public string Value { get; set; }
        public string FilePath { get; set; }
        public int Position { get; set; }
    }
}
