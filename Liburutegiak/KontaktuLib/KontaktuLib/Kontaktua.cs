using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktuLib
{
    public class Kontaktua
    {
        public string Izena { get; set; }
        public string Abizena { get; set; }
        public string Telefonoa { get; set; }
        public string Generoa { get; set; }
        public string Prefijoa { get; set; }

        public Kontaktua(string Izena, string Abizena, string Telefonoa, string Generoa, string Prefijoa)
        {
            this.Izena = Izena;
            this.Abizena = Abizena;
            this.Telefonoa = Telefonoa;
            this.Generoa = Generoa;
            this.Prefijoa = Prefijoa;
        }

        public static void gordeKontaktua(Kontaktua kontaktua, List<Kontaktua> agenda)
        {
            agenda.Add(kontaktua);
            Console.WriteLine("Kontaktua agendan gorde da");
        }
    }
}
