using Dash.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Dash.Managers
{
    public class JeloManager : AbstractManager<Jelo>
    {
        public JeloManager() : base()
        {
            Jelo.lastID = managed.Count + 1;
        }

        public void AddJelo(string naziv, string opis, int cena, double gramaza, bool obavezanPrilog)
        {
            managed.Add(new Jelo(naziv, opis, cena, gramaza, obavezanPrilog));
        }

        public bool DodatakPostoji(int id)
        {
            var pronadji = managed.FirstOrDefault(jelo => jelo.GetDodatke().Contains(id));
            return pronadji != null;
        }

        public bool PrilogPostji(int id)
        {
            var pronadji = managed.FirstOrDefault(jelo => jelo.GetPriloge().Contains(id));
            return pronadji != null;
        }

        public IList<Jelo> GetByRestoran(Restoran restoran)
        {
            return managed.Where(jelo => jelo.ImaRestoran(restoran.Id)).ToList();
        }

        public override void PreventCollision()
        {
            while (FindById(Restoran.lastID) != null)
                Restoran.lastID++;
        }

        protected override void Serialize()
        {
            Serialization.Write("jela.bin", managed);
        }

        protected override IList<Jelo> Deserialize()
        {
            return Serialization.Read<List<Jelo>>("jela.bin");
        }
    }
}
