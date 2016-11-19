using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //float
            System.Console.WriteLine(6.023E23f);
            //Hexadecimal literal
            System.Console.WriteLine(0x002A);
            //displays hexadecimal
            System.Console.WriteLine("0x{0:X}", 56);
            string option = System.Console.ReadLine();
            int comparison = string.Compare(option, "hej", true);
            System.Console.WriteLine(comparison.ToString());
            System.Console.ReadLine();
        }
    }
}
