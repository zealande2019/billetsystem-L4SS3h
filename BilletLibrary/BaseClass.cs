using System;

namespace BilletLibrary
{
    public abstract class BaseClass
    {
        protected string _nummerPlade;
        public DateTime _dato;
        public bool broBizz;

        public BaseClass(string nummerPlade, DateTime dato)
        {
            _nummerPlade = nummerPlade;
            _dato = dato;
            broBizz = true;
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
        public abstract string Type();
        public abstract double Pris();


    }
}