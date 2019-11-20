using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace raides
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filepath = @"C:\Users\grauk\Desktop\Objectinis programavimas\Raidės\raides.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            StringBuilder linija = new StringBuilder { };
            List<string> nlines = new List<string>{};
            
            foreach (string Line in lines)
            {
             
                int i = 0;
                foreach (char symbol in Line)
                {
                    if (Char.IsUpper(symbol))
                    {
                        linija.Insert(i, char.ToLower(symbol));
                    }

                    else if (Char.IsLower(symbol))
                    {
                        linija.Insert(i, char.ToUpper(symbol));
                    }
                    else
                    {
                        linija.Insert(i, symbol);
                    }
                    i++;
                }
                nlines.Add(linija.ToString());
                linija.Clear();
            }
            Console.WriteLine("Iveskite isvedamo failo kelia ir vieta");
            string filepath2=Console.ReadLine();
            File.WriteAllLines(filepath2, nlines);
        }
    }
}
