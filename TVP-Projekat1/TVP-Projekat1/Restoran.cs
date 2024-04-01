using Dash.Managers;
using System;

namespace Dash
{
    [Serializable]
    public class Restoran : IManaged
    {
        public static int lastID = 1;
        private readonly int id;
        private string naziv;
        private string adresa;
        private string kontakt;

        public Restoran(string naziv, string adresa, string kontakt)
        {
            this.id = lastID++;
            this.naziv = naziv;
            this.adresa = adresa;
            this.kontakt = kontakt;
        }

        public int Id => id;

        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Kontakt { get => kontakt; set => kontakt = value; }

        public override string ToString()
        {
            return naziv;
        }
    }
}
