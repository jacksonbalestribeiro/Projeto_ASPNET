using System;

namespace SalesWebMvc.Services.Exeptions
{
    public class DbConcurrencyExeption : ApplicationException
    {
        public DbConcurrencyExeption(string message) : base(message)
        { 
        } 
    }
}
