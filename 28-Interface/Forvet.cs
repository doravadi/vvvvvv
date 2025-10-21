using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Interface
{
    public class Forvet : IFutbolcu
    {
        public string Name { get; set; }
        public int Numarasi { get; set; }
        public int PasGucu { get; set; }
        public int SutGucu { get; set; }
        public int KosuGucu { get; set; }

        public void Kos()
        {
            Console.WriteLine("koşu başladı...");
        }

        public void PasAt()
        {
            Console.WriteLine("pas atılıyor...");
        }

        public void SutCek()
        {
            Console.WriteLine("şut çekiliyor...");
        }
    }
}
