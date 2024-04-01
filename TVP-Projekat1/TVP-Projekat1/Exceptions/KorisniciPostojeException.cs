using System;

namespace Dash.Exceptions
{
    internal class KorisniciPostojeException : Exception
    {
        public KorisniciPostojeException() : base ("Korisnik sa tim username-om postoji!") { }
    }
}
