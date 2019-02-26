using System;

namespace BilletLibrary
{
    public class Bil : BaseClass
    {

        public Bil(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
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
                double rabat = 0.95 * 240;
                return rabat;
            }
            return 240;
        }
        /// <summary>
        /// Oversrkiver abstract metode fra BaseClass.cs
        /// </summary>
        /// <returns>bil</returns>
        public override string Type()
        {
            return "bil";
        }
    }
}