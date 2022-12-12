using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

            using (StreamWriter sw = new StreamWriter(filename)){
                sw.Write(s);
            }

        }

        public static void kopirujSoubor(string filenameSource, string filenameDest)
        {
            using (StreamWriter sw = new StreamWriter(filenameDest))
            {
                using (StreamReader sr = new StreamReader(filenameSource))
                {
                    string ln;

                    while ((ln = sr.ReadLine()) != null)
                    {
                        foreach (char c in ln)
                        {
                            sw.Write(Char.ToLower(c));
                        }
                        sw.Write('\n');
                    }
                }
            }
        }
    }

}