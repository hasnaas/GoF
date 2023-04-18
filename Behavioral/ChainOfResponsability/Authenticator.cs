using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class Authenticator : Handler
    {

        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            var isValid = (request.Username == "admin" &&
                   request.Password == "1234");

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}
