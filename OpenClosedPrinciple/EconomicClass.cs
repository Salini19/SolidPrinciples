using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class EconomicClass :Flight
    {
        public override void BookTicket(Passanger passanger) 
        {
            Console.WriteLine("EconomicClass Ticket");
        }
    }
}
