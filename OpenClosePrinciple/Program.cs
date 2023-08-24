// See https://aka.ms/new-console-template for more information
using OpenClosePrinciple;

Console.WriteLine("Hello, World!");

Passanger passanger = new Passanger();
Flight flight = new FirstClass();

flight.BookTicket(passanger);
