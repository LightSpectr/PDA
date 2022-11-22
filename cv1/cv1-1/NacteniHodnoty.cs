using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Read
{
    static class NacteniHodnoty
    {
        string input = Console.ReadLine();

        if (Int32.TryParse(input, out _))
        {
             Console.WriteLine("Input is Integer");
        }
       else if (Single.TryParse(input, out _))
        {
             Console.WriteLine("Input is Float");
        }
       else if (Int64.TryParse(input, out _))
        {
             Console.WriteLine("Input is Long");
        }
              else if (Byte.TryParse(input, out _))
        {
             Console.WriteLine("Input is Byte");
        }
              else if (Int16.TryParse(input, out _))
        {
             Console.WriteLine("Input is Short");
        }
              else if (Double.TryParse(input, out _))
        {
             Console.WriteLine("Input is Double");
        }
              else if (Char.TryParse(input, out _))
        {
             Console.WriteLine("Input is Char");
        }
              else if (String.TryParse(input, out _))
        {
             Console.WriteLine("Input is String");
        }
    else
    {
             Console.WriteLine("Input is other data type.");
    }

    }
}
