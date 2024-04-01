using Dash.Utilities;
using System.Collections.Generic;


namespace Dash.Managers
{
    public class PrilogManager : AbstractManager<Prilog>
    {
        public PrilogManager() : base()
        {
            Prilog.lastID = managed.Count + 1;
        }

        public void AddPrilog(string naziv, int cena)
        {
            managed.Add(new Prilog(naziv, cena));
        }

        public override void PreventCollision()
        {
            while (FindById(Prilog.lastID) != null)
                Prilog.lastID++;
        }

        protected override void Serialize()
        {
            Serialization.Write("prilozi.bin", managed);
        }

        protected override IList<Prilog> Deserialize()
        {
            return Serialization.Read<List<Prilog>>("prilozi.bin");
        }
    }
}
