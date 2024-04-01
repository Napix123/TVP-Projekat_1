using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Dash
{
    [Serializable]
    public class NarucenoJelo
    {
        private readonly Jelo jelo;
        private readonly Prilog prilog;
        private readonly IList<Dodatak> dodaci;

        public NarucenoJelo(Jelo jelo, Prilog prilog, IList<Dodatak> dodaci)
        {
            this.jelo = jelo;
            this.prilog = prilog;
            this.dodaci = dodaci;
        }

        public int GetCena()
        {
            int cenaDodaci = 0;
            foreach(Dodatak dodatak in dodaci)
            {
                cenaDodaci += dodatak.Cena;
            }
            return cenaDodaci + (prilog?.Cena ?? 0) + jelo.Cena;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NarucenoJelo other)) return false;
            return other.jelo.Id == this.jelo.Id && other.prilog?.Id == this.prilog?.Id
                && this.dodaci.Select(dodatak => dodatak.Id).SequenceEqual(other.dodaci.Select(dodatak => dodatak.Id));
        }

        public override int GetHashCode()
        {
            int hashKod = 17;
            hashKod = hashKod * 5 + jelo.GetHashCode();
            hashKod = hashKod * 5 + prilog?.GetHashCode() ?? 0;
            foreach (var dodatak in dodaci)
            {
                hashKod = hashKod * 5 + dodatak.GetHashCode();
            }
            return hashKod;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("Jelo: " + jelo);
            builder.Append(' ');
            if (prilog != null)
            {
                builder.Append("Prilog: (" + prilog + ")");
                builder.Append(' ');
            }
            if (dodaci.Count > 0)
            {
                builder.Append("Dodaci: [");
            }
            foreach (Dodatak dodatak in dodaci)
            {
                builder.Append($" {dodatak},");
            }
            if (dodaci.Count > 0)
            {
                builder.Append("]");
            }
            return builder.ToString();
        }

        public static bool operator ==(NarucenoJelo left, NarucenoJelo right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(NarucenoJelo left, NarucenoJelo right)
        {
            return !(left == right);
        }
    }
}
