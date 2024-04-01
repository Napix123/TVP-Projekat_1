using Dash.Utilities;
using System.Collections.Generic;

namespace Dash.Managers
{
    public class DodatakManager : AbstractManager<Dodatak>
    {
        public DodatakManager() : base()
        {
            Dodatak.lastID = managed.Count + 1;
        }

        public override void PreventCollision()
        {
            while (FindById(Dodatak.lastID) != null)
                Dodatak.lastID++;
        }

        public void DodajDodatak(string naziv, int cena, double gramaza)
        {
            managed.Add(new Dodatak(naziv, cena, gramaza));
        }

        protected override void Serialize()
        {
            Serialization.Write("dodaci.bin", managed);
        }

        protected override IList<Dodatak> Deserialize()
        {
            return Serialization.Read<List<Dodatak>>("dodaci.bin");
        }
    }
}
