using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class FirstClass : Flight
    {
        public override void BookTicket(Passanger passanger)
        {
            Console.WriteLine("FirstClass Ticket");
        }
    }
}
