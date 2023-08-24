using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple
{
    internal class Class1
    {
    }
   public interface IFileRead
    {
        void ReadFile();
    }
    public interface IFileWrite
    {
        void WriteFile();
    }
    internal class AdminFileUser : IFileRead, IFileWrite
    {
        public void ReadFile() 
        { 
            Console.WriteLine("Admin Read File"); 
        }
        public void WriteFile() 
        { 
            Console.WriteLine("Admin Write File"); 
        }
    }
    internal class NormalFileUser : IFileRead
    {
        public void ReadFile() 
        { 
            Console.WriteLine("Normal Read File"); 
        }
    }
    internal class AccessDataFile
    {
        public string Path { get; set; }

        public virtual void ReadFile() 
        { 
            Console.WriteLine("Read File"); 
        }
        public virtual void WriteFile() 
        { 
            Console.WriteLine("Write File"); 
        }
    }
}
