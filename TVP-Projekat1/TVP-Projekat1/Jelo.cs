using Dash.Managers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace Dash
{
    [Serializable]
    public class Jelo : Namernica, IManaged
    {
        public const int MAX_Dodataka = 3;
        public static int lastID = 1;

        private string opis;
        private bool obavezanPrilog;
        private ISet<int> dodaci;
        private ISet<int> prilozi;
        private ISet<int> restorani;
        public Jelo(string naziv, string opis, int cena, double gramaza, bool obavezanPrilog) : base(lastID++, naziv, cena, gramaza)
        {
            this.opis = opis;
            this.obavezanPrilog = obavezanPrilog;
            dodaci = new HashSet<int>();
            prilozi = new HashSet<int>();
            restorani = new HashSet<int>();
        }

        public void DodajMogucPrilog(int id)
        {
            prilozi.Add(id);
        }

        public void DodajURestoran(int id)
        {
            restorani.Add(id);
        }

        public void DodajMogucDodatak(int id)
        {
            dodaci.Add(id);
        }

        public bool ImaRestoran(int id)
        {
            return restorani.Contains(id);
        }

        public void ObrisiDodatak(int id)
        {
            dodaci.Remove(id);
        }

        public void ObrisiRestoran(int id)
        {
            restorani.Remove(id);
        }

        public IList<int> GetPriloge()
        {
            return new ReadOnlyCollection<int>(prilozi.ToList());
        }

        public IList<int> GetDodatke()
        {
            return new ReadOnlyCollection<int>(dodaci.ToList());
        }

        public IList<int> GetRestorane()
        {
            return new ReadOnlyCollection<int>(restorani.ToList());
        }

        public override string ToString()
        {
            return $"{Naziv} Cena:{Cena}din Gramaza:{Gramaza}g";
        }

        public override bool Equals(object obj)
        {
            return obj is Jelo jelo &&
                Id == jelo.Id && Naziv == jelo.Naziv;
        }

        public override int GetHashCode()
        {
            return 7 + Id.GetHashCode() + Naziv.GetHashCode();
        }

        public string Opis { get => opis; set => opis = value; }
        public bool ObavezanPrilog { get => obavezanPrilog; set => obavezanPrilog = value; }
    }
}
