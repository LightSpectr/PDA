using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1, text2;

            string test = "ABCD1234";
            string result = test.ToHex();

            text1 = Console.ReadLine();            
            text2 = Console.ReadLine();

          
            Console.Write("Jmeno: ");
            Console.Write(text1);
            Console.Write("Prijmeni");
            Console.Write(text2);

            
            Console.Write(text1 + " " + text2+"\n");

           
            Console.Write(text1.Substring(0, 1) + " " + text2Substring(0, 1));

            private static String HexConverter(System.Drawing.Color c)
            {
                return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }

            private static String RGBConverter(System.Drawing.Color c)
            {
                return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
            }
            string value = "9quali52ty3";

            byte[] asciiBytes = Encoding.ASCII.GetBytes(value);

        }
        public static class StringExtensions
        {
            public static string ToHex(this string input)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in input)
                    sb.AppendFormat("0x{0:X2} ", (int)c);
                return sb.ToString().Trim();
            }
        }
    }
}