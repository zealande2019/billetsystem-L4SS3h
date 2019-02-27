using System;

namespace BilletLibrary
{
    public abstract class BaseClass
    {
        protected string _nummerPlade;
        public DateTime _dato;
        public bool broBizz;
        /// <summary>
        /// Constructor hvor længden af nummerplade tjekkes.
        /// Hvis nummerplader er for bliver der kastet en ny argument exception.
        /// </summary>
        /// <param name="nummerPlade"></param>
        /// <param name="dato"></param>
        public BaseClass(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            broBizz = true;
        }
        /// <summary>
        /// En metode som retunere nummerpladen
        /// </summary>
        public string Nummerplade
        {
            get { return _nummerPlade; }
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("Nummerplade kan ikke være længere end 7 tegn.");
                _nummerPlade = value;
            }
        }
        /// <summary>
        /// Abstract metoder der bliver overskrevet i henholdsvis bil og mc.
        /// </summary>
        /// <returns></returns>
        public abstract string Type();
        /// <summary>
        /// Abstract metode som repræsentere pris, som skal overskrives.
        /// </summary>
        public abstract double Pris();

        public DateTime Dato { get; set; }


    }
}