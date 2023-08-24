using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class BussinessClass: Flight
    {
        public override void BookTicket(Passanger passanger)
        {
            Console.WriteLine("BussinessClass Ticket");
        }
        
    }
}
