using System;
using Dash.Managers;

namespace Dash
{
    [Serializable]
    public class Prilog : Proizvod, IManaged
    {
        public static int lastID = 1;
        public Prilog(string naziv, int cena) : base(lastID++, naziv, cena)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Prilog prilog &&
                Id == prilog.Id && Naziv == prilog.Naziv;
        }

        public override int GetHashCode()
        {
            return 3 + Id.GetHashCode() + Naziv.GetHashCode();
        }

        public override string ToString()
        {
            return $"Naziv: {Naziv} Cena: {Cena}din";
        }
    }
}
