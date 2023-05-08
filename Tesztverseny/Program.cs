using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztverseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok("valaszok.txt");
            Console.WriteLine("Beolvasás kész");

            
            Console.WriteLine(f.Megoldasok);
            Console.WriteLine("f.Megoldasok");




            Console.ReadLine();
        }
    }
}
