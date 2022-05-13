using System;

namespace SalesWebMvc.Services.Exeptions
{
    public class IntegrityExeption :  ApplicationException
    {
        public IntegrityExeption(string message) : base(message)
        {
        }
    }
}
