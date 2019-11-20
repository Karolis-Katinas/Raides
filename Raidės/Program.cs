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
            List<string> lines = new List<string> { };
            string filepath;
            
            do
            {
                Console.WriteLine("Iveskite faila, kuri norite konvertuoti");
                filepath = Console.ReadLine();
                if ((File.Exists(filepath))&&(filepath.EndsWith(".txt")))
                {
                    lines = File.ReadAllLines(filepath).ToList();
                }
                else Console.WriteLine("Failas neegzistuoja!");
            } while (!(File.Exists(filepath)&&(filepath.EndsWith(".txt"))));

            List<string> nlines = new List<string> { };
            StringBuilder linija = new StringBuilder { };
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
            string filepath2 = filepath.Remove(filepath.Length-4, 4) + "_converted.txt";
            File.WriteAllLines(filepath2, nlines);
        }
    }
}
