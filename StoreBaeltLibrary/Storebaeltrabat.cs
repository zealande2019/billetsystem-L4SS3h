using System;
using BilletLibrary;

namespace StoreBaeltLibrary
{
    public class Storebaeltrabat
    {
        public double Weekend(Bil nyBil)
        {
            if (nyBil._dato.DayOfWeek == DayOfWeek.Saturday || nyBil._dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return nyBil.Pris() * 0.8;
            }
            return nyBil.Pris();
        }
    }
}
