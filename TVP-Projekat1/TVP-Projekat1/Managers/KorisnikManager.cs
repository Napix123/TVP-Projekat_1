using Dash.Utilities;
using Dash.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;


namespace Dash.Managers
{
    public class KorisnikManager : AbstractManager<Korisnik>
    {
        public KorisnikManager() : base(new Korisnik("Admin", "Korisnik", "admin", "TVPProjekat", TipKorisnika.ADMIN))
        {
            Korisnik.lastID = managed.Count + 1;
        }

        public Korisnik TryLogin(string username, string password)
        {
            var korisnik = FindByUsername(username);
            if (korisnik != null && !korisnik.TryLogin(password))
                throw new AuthenticationException();

            return korisnik;
        }

        public void AddUser(
            string ime,
            string prezime,
            string username,
            string password,
            TipKorisnika tip
            )
        {
            var korisnik = FindByUsername(username);

        }

        public override void PreventCollision()
        {
            while (FindById(Korisnik.lastID) != null)
                Korisnik.lastID++;
        }

        protected override void Serialize()
        {
            Serialization.Write("korisnici.bin", managed);
        }

        protected override IList<Korisnik> Deserialize()
        {
            return Serialization.Read<List<Korisnik>>("korisnici.bin");
        }

        private Korisnik FindByUsername(string username)
        {
            return managed.Where(kor => kor.Username == username).FirstOrDefault();
        }
        
    }
}
