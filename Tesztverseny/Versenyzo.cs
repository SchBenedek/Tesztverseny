using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztverseny
{
    internal class Versenyzo
    {
        private string nev;
        private char[] pontok = new char[14];
        public Versenyzo(string nev, char[] pontok)
        {
            this.nev = nev;
            this.pontok = pontok;
        }

        public string Nev { get => nev; set => nev = value; }
        public char[] Pontok { get => pontok; set => pontok = value; }
        public override string ToString()
        {
            string a = "";
            foreach (char s in pontok)
            {
                a += s+", ";
            }
            return $"név: {this.nev}, pontok: {a}";
        }
    }
}
