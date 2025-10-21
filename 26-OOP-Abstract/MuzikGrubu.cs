using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_OOP_Abstract
{
    public class MuzikGrubu
    {
        public string GrupAdi { get; set; }
        public List<Muzisyen> Calgicilar { get; set; } = new List<Muzisyen>();

        public MuzikGrubu(string grupAdi)
        {
            GrupAdi = grupAdi;
        }
    }
}
