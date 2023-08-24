using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal abstract class Flight
    {
        public int FlightId { get; set; }
        public string Name { get; set; }

        public abstract void BookTicket(Passanger passanger);

    }
    internal class Passanger
    {
        public int PId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    internal class BussinessClass : Flight
    {
        public override void BookTicket(Passanger passanger)
        {
            Console.WriteLine("BussinessClass Ticket");
        }

    }
    internal class EconomicClass : Flight
    {
        public override void BookTicket(Passanger passanger)
        {
            Console.WriteLine("EconomicClass Ticket");
        }
    }
    internal class FirstClass : Flight
    {
        public override void BookTicket(Passanger passanger)
        {
            Console.WriteLine("FirstClass Ticket");
        }
    }

}
