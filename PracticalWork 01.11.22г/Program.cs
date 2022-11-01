using PracticalWork_01._11._22г;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticalWork_01._11._22г
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College group = new College();
            group.Name = "5ИСиП-2";
            group.Training = "очное";
            group.Quantity = 24;
            Console.WriteLine(group.Display());
            Console.ReadKey();
        }
    }
}

