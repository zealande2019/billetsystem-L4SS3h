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
        /// <summary>
        /// Hvis brobizz er sat til true i BaseClass.cs så regnes der en rabat
        /// ellers er det bare en standard pris
        /// </summary>
        /// <returns></returns>
        public override double Pris()
            {
                if (broBizz == true)
                {
                    double rabat = 0.95 * 125;
                    return rabat;
                }
                return 240;
            }
            /// <summary>
            /// Overskriver metode fra BaseClass.cs
            /// </summary>
            /// <returns>mc</returns>

            public override string Type()
            {
                return "mc";
            }
        }
    }
