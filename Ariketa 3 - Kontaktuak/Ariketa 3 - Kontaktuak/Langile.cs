using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_3___Kontaktuak
{
    internal class Langile : Bezeroa
    {
        private double Soldata { get; set; }
        private string SegurtasunSoziala { get; set; }

        private string _emaila;
        
        public override string Emaila 
        {
            get { return _emaila; }
            set
            {
                try
                {
                    if (value.Substring(value.Length - 14, 14) != "@iesunibhi.com")
                    {
                        Exception ex = new Exception("Emaila ez duzu ondo jarri");
                        throw ex;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errorea: {ex.Message}");
                }
            }
        }

        public override void Gorde()
        {
            Console.WriteLine("Langilea ondo gorde da");
        }
    }
}
