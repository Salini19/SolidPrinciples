using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeggrigation
{
   
    public class Aircraft : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Running");
        }
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
    public class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Running");
        }
    }

}
