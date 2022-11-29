using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal static class MojeSouboroveOperace
    {
        public static void vytvorNahodnySoubor(string filename, int countChar) {
            Random random = new Random();
           
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            String s = new string(Enumerable.Repeat(chars, countChar)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt")){
                sw.Write(s);
            }

        }
    }

}