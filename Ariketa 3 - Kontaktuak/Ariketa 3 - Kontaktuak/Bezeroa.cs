using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_3___Kontaktuak
{
    internal class Bezeroa : Kontaktuak
    {
        private string Kategoria { get; set; }

        public override void Gorde()
        {
            Console.WriteLine("Bezeroa ondo gorde da");
        }
    }
}
