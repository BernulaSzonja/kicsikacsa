using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kicsikacsa
{
    internal class Book
    {
        Random rnd = new Random();

        private long ISBN { get; set; }
        private List<Author> szerzo { get; set; }
        private string cim { get; set; }
        private int kiadas { get; set; }
        private string nyelv { get; set; }
        public int keszlet { get; set; }
        private int ar { get; set; }


        public Book(long iSBN, List<Author> szerzo, string cim, int kiadas, string nyelv, int keszlet, int ar)
        {
            if(ISBN.ToString().Length != 10)
               throw new ArgumentException("az azonosito 10 karakter hosszu szamsor");
  

            if(cim.Length < 3 && cim.Length > 64)
                throw new ArgumentException("a cim hossza 3 es 64 karakter kozott lehet");
            if(kiadas < 2007 || kiadas > 2024)
                throw new ArgumentException("a kiadasi evnek 2007 es 2024 kozott kell lennie");
            if(nyelv != "angol" && nyelv != "német" && nyelv != "magyar")
                throw new ArgumentException("a konyv nyelve angol, magyar vagy német lehet");
            if(keszlet < 0)
                throw new ArgumentException("keszletnek nem lehet minusz szamot megadni");
            if(ar < 0 )
                throw new ArgumentException("arnak nem lehet megadni minusz erteket");
            if (ar % 100 != 0)
                throw new ArgumentException("az arnak 100-al oszthato szamnak kell lennie");

            ISBN = iSBN;
            this.szerzo = szerzo;
            this.cim = cim;
            this.kiadas = kiadas;
            this.nyelv = nyelv;
            this.keszlet = keszlet;
            this.ar = ar;
        }
        public Book(string szerzo, string cim)
        {
            ISBN = rnd.Next(10000000, 99999999) * 10;
            this.cim = cim;
            this.szerzo = new List<Author>() { new Author(szerzo) };
            this.kiadas = 2024;
            this.nyelv = "magyar";
            this.keszlet = 0;
            this.ar = 4500;
        }
        public override string ToString()
        {

            return $"Könyv ISBN száma: {this.ISBN}\n" +
                $"Címe: {this.cim}\n" +
                $"{(this.szerzo.Count > 1 ? "Szerzők: " : "Szerző: ")}\n" +
                $"Kiadás éve: {this.kiadas}\n" +
                $"Nyelve: {this.nyelv}\n" +
                $"Készleten: {(this.keszlet > 0 ? $"{this.keszlet}db" : "beszerzés alatt")} \n" +
                $"Ára: {this.ar}";
        }
    }
}
