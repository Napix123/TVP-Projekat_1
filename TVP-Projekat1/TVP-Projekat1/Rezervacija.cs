using System.Globalization;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Dash.Managers;

namespace Dash
{
    [Serializable]
    public class Rezervacija : IManaged
    {
        public static int lastID = 1;
        private readonly int id;
        private int idKorisnika;
        private DateTime datum;
        private IDictionary<NarucenoJelo, int> jela;

        public Rezervacija(int idKorisnika)
        {
            id = lastID;
            this.idKorisnika = idKorisnika;
            jela = new IDictionary<NarucenoJelo, int>();
        }

        public void DodajJelo(Jelo jelo, IList<Dodatak> dodaci, Prilog prilog = null)
        {
            if (dodaci.Count > Jelo.MAX_Dodataka) throw new ArgumentOutOfRangeException("Jelo može da ima 3 dodataka!");
            NarucenoJelo jeloWrapper = new NarucenoJelo(jelo, prilog, dodaci);
            jela.TryGetValue(jeloWrapper, out int trenutnoJelo);
            jela[jeloWrapper] = trenutnoJelo + 1;
        }

        public int UkupnaCena()
        {
            return jela.Keys.Select(key => key.GetCena() * jela[key]).Sum();
        }

        public IDictionary<NarucenoJelo, int> GetTrenutnoJelo() => new ReadOnlyDictionary<NarucenoJelo, int>(jela);

        public void ObrisiJelo(NarucenoJelo jelo)
        {
            jela.TryGetValue(jelo, out int trenutnoJelo);
            if (trenutnoJelo < 2) jela.Remove(jelo);
            else jela[jelo] = trenutnoJelo - 1;
        }

        public void ZavrsiRezervaciju()
        {
            lastID++;
        }

        public int IdKorisnika { get => idKorisnika; set => idKorisnika = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public int Id { get => id; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach(NarucenoJelo jeloWrapper in jela.Keys)
            {
                builder.AppendLine($"{jeloWrapper} Komada: x{jela[jeloWrapper]} Datum: {datum.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)}");
                builder.AppendLine();
            }
            builder.AppendLine("Ukupna cena: " + UkupnaCena() + "din");
            return builder.ToString();
        }
    }
}
