using System;


namespace Dash
{
    [Serializable]
    public abstract class Namernica : Proizvod
    {
        private double gramaza;
        protected Namernica(int id, string naziv, int cena, double gramaza) : base(id, naziv, cena)
        {
            this.gramaza = gramaza;
        }

        public double Gramaza { get => gramaza; set => gramaza = value; }
    }
}
