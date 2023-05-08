using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tesztverseny
{
    internal class Feladatok
    {
        private List<Versenyzo> lista = new List<Versenyzo>();
        private string megoldasok;

        public string Megoldasok { get => megoldasok; set => megoldasok = value; }

        public Feladatok(string filenév)
        {
            Beolvas(filenév);
        }
        public void Beolvas(string filenév)
        {
            StreamReader sr = new StreamReader(filenév);
            megoldasok = sr.ReadLine();
            while(!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(' ');
                char[] b = line[1].ToCharArray();
                lista.Add(new Versenyzo(line[0], b));
            }
        }

        public int Masodik()
        {
            return lista.Count;
        }

        public char[] Harmadik(string azonosito)
        {
            foreach (Versenyzo v in lista)
            {
                if(v.Nev == azonosito)
                {
                    return v.Pontok;
                }
            }
            return null;
        }
    }
}
