using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passanger passanger = new Passanger();
            Flight flight = new FirstClass();

            flight.BookTicket(passanger);
            Console.WriteLine("HelloWorld");
            
        }
    }
}
