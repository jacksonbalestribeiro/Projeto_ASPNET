using System;

namespace SalesWebMvc.Services.Exeptions
{
    public class NotFoundExcepion : ApplicationException
    {
        public NotFoundExcepion(string message) : base(message)
        {
        }
    }
}
