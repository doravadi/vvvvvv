using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_OOP_Abstract
{
    public class Fulut : MuzikAleti
    {
        public Fulut(string marka, string aciklama) : base(marka, aciklama)
        {
        }

        public override string Cal()
        {
            return "Fülüt sesi...";
        }
    }
}
