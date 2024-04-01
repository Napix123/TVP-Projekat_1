using Dash.Exceptions;
using Dash.Utilities;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dash.Managers
{
    public class RestoranManager : AbstractManager<Restoran>
    {
        public static Regex telefonRegex = new Regex(@"^0[0-9]{2}/[0-9]{7}");
        public RestoranManager() : base()
        {
            Restoran.lastID = managed.Count + 1;
        }

        public void AddRestoran(string naziv, string adresa, string kontakt)
        {
            if (!telefonRegex.IsMatch(kontakt)) throw new InvalidPhoneException();
            managed.Add(new Restoran(naziv, adresa, kontakt));
        }

        public override void PreventCollision()
        {
            while (FindById(Restoran.lastID) != null)
                Restoran.lastID++;
        }

        protected override void Serialize()
        {
            Serialization.Write("restorani.bin", managed);
        }

        protected override IList<Restoran> Deserialize()
        {
            return Serialization.Read<List<Restoran>>("restorani.bin");
        }
    }
}
