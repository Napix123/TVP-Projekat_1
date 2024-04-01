using System;


namespace Dash.Exceptions
{
    internal class InvalidPhoneException : Exception
    {
        public InvalidPhoneException() : base ("Nije važeci format telefona!") { }
    }
}
