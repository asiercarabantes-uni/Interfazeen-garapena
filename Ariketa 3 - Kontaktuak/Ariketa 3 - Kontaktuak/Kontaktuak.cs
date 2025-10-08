using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_3___Kontaktuak
{
    internal class Kontaktuak
    {
        private string Nan { get; set; }
        private string Izena { get; set; }
        private string Abizena { get; set; }
        public virtual string Emaila { get; set; }
        private string IzenOsoa { get; }

        public virtual void Gorde() 
        {
            Console.WriteLine("Kontaktua ondo gorde da");
        }
    }
}
