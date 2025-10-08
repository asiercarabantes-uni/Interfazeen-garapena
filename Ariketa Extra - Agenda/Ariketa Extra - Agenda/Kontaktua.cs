using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_Extra___Agenda
{
    internal class Kontaktua
    {
        private string Izena { get; set; }
        private string Abizena { get; set; }
        private string Telefonoa { get; set; }
        private string Generoa { get; set; }
        private string Prefijoa { get; set; }

        public Kontaktua(string Izena, string Abizena, string Telefonoa, string Generoa, string Prefijoa)
        {
            this.Izena = Izena;
            this.Abizena = Abizena;
            this.Telefonoa = Telefonoa;
            this.Generoa = Generoa;
            this.Prefijoa = Prefijoa;
        }


    }
}
