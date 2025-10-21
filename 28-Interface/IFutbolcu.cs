using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Interface
{
    public interface IFutbolcu
    {
        string Name { get; set; }
        int Numarasi { get; set; }
        int PasGucu { get; set; }
        int SutGucu { get; set; }
        int KosuGucu { get; set; }

        void PasAt();
        void SutCek();
        void Kos();
    }
}
