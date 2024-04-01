using System;


namespace Dash
{
    [Serializable]
    public abstract class Proizvod
    {
        private readonly int id;
        private string naziv;
        private int cena;

        protected Proizvod(int id, string naziv, int cena)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
        }

        public int Id => id;

        public string Naziv { get => naziv; set => naziv = value; }
        public int Cena { get => cena; set => cena = value; }
    }
}
