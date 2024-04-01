using Dash.Managers;
using Dash.Utilities;
using System;
using System.Security.Policy;

namespace Dash
{
    [Serializable]
    public class Korisnik : IManaged
    {
        public static int lastID = 1;

        private readonly int id;
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string hashedLozinka;
        private TipKorisnika tipKorisnika;

        public Korisnik(string ime, string prezime, string korisnickoIme, string password, TipKorisnika tipKorisnika)
        {
            id = lastID++;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.hashedLozinka = Encryption.Encrypt(password);
            this.tipKorisnika = tipKorisnika;
        }

        public bool TryLogin(string password)
        {
            return Encryption.Encrypt(password) == hashedLozinka;
        }

        public bool IsAdmin()
        {
            return tipKorisnika == TipKorisnika.ADMIN;
        }

        public override string ToString()
        {
            return korisnickoIme;
        }
        public int Id => id;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => korisnickoIme; set => korisnickoIme = value; }
        public string Password { set => hashedLozinka = Encryption.Encrypt(value); }
        public TipKorisnika TipKorisnika { get => tipKorisnika; set => tipKorisnika = value; }

    }

    public enum TipKorisnika
    {
        ADMIN,
        KLIJENT
    }
}
