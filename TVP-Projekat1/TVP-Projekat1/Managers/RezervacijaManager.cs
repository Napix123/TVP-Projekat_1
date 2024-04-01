using Dash.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace Dash.Managers
{
    public class RezervacijaManager : AbstractManager<Rezervacija>
    {
        public RezervacijaManager() : base()
        {
            Rezervacija.lastID = managed.Count + 1;
        }

        public void AddRezervacija(Rezervacija rezervacija)
        {
            managed.Add(rezervacija);
        }

        public IList<Rezervacija> GetRezervacijaByKorisnik(int id)
        {
            return managed.Where(rez => rez.IdKorisnika == id).ToList();
        }

        public override void PreventCollision()
        {
            while (FindById(Rezervacija.lastID) != null)
                Rezervacija.lastID++;
        }

        protected override void Serialize()
        {
            Serialization.Write("rezervacije.bin", managed);
        }

        protected override IList<Rezervacija> Deserialize()
        {
            return Serialization.Read<List<Rezervacija>>("rezervacije.bin");
        }
    }
}
