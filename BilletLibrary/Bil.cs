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

        public override double Pris()
        {
            if (broBizz == true)
            {
                double rabat = 0.95 * 240;
                return rabat;
            }
            return 240;
        }

        public override string Type()
        {
            return "bil";
        }
    }
}