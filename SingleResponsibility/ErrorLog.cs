using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public static class ErrorLog
    {
        public static void WriteLog(string[] messages)
        {
            System.IO.File.WriteAllLines(@"C:\\users\\source\\repos\\SolidPrinciples\Error.txt", messages);
        }
    }
}
