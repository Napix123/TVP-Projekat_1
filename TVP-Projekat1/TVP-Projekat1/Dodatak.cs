using System;
using Dash.Managers;

namespace Dash
{
    [Serializable]
    public class Dodatak : Namernica, IManaged
    {
        public static int lastID = 1;
        public Dodatak(string naziv, int cena, double gramaza) : base(lastID++, naziv, cena, gramaza)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Dodatak dodatak &&
                Id == dodatak.Id && Naziv == dodatak.Naziv;
        }

        public override int GetHashCode()
        {
            return 5 + Id.GetHashCode() + Naziv.GetHashCode();
        }

        public override string ToString()
        {
            return $"Naziv: {Naziv} Gramaza: {Gramaza}g Cena: {Cena}din";
        }
    }
}
