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
        public BaseClass(string nummerPlade, DateTime dato)
        {
            _nummerPlade = nummerPlade;
            _dato = dato;
            broBizz = false;
            if (nummerPlade.Length > 7)
            {
                throw new ArgumentException("Nummerplade er for lang!!");
            }
        }
        public string Nummerplade
        {
            get { return _nummerPlade; }
            set { _nummerPlade = value; }
        }
        /// <summary>
        /// Abstract metoder der bliver overskrevet i henholdsvis bil og mc.
        /// </summary>
        /// <returns></returns>
        public abstract string Type();
        public abstract double Pris();


    }
}