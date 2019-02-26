using System;
using BilletLibrary;

namespace OersundLibrary
{
    public class OersundPris
    {
        public string Type(BaseClass type)
        {
            if (type.Type() == "bil")
            {
                return "øresund bil";
            }

            return "øresund mc";
        }
        public double Pris(BaseClass type)
        {
            if(type.Type() == "bil")
            {
                if (type.broBizz == true)
                {
                    return 161;
                }

                return 410;
            }
            if (type.Type() == "mc")
            {
                if (type.broBizz == true)
                {
                    return 73;
                }

                return 210;
            }

            return 0;
        }
    }
}
