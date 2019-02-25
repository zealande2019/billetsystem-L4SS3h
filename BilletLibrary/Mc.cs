using System;

namespace BilletLibrary
{
    
        public class Mc : BaseClass
        {
            public Mc(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
            {
                nummerPlade = Nummerplade;
                dato = _dato;
            }

            public override double Pris()
            {
                if (broBizz == true)
                {
                    double rabat = 0.95 * 125;
                    return rabat;
                }
                return 240;
            }

            public override string Type()
            {
                return "mc";
            }
        }
    }
