using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace raides
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filepath = @"C:\Users\grauk\Desktop\Objectinis programavimas\Raidės\raides.txt";
            List<string> Lines = File.ReadAllLines(filepath).ToList();
            StringBuilder linija = new StringBuilder { };
            List<string> Nlines = new List<string>{};
            
            foreach (string Line in Lines)
            {
             
                int i = 0;
                foreach (char Symbol in Line)
                {
                    if (Char.IsUpper(Symbol))
                    {
                        linija.Insert(i, char.ToLower(Symbol));
                    }

                    else if (Char.IsLower(Symbol))
                    {
                        linija.Insert(i, char.ToUpper(Symbol));
                    }
                    else
                    {
                        linija.Insert(i, Symbol);
                    }
                    i++;
                }
                Nlines.Add(linija.ToString());
                linija.Clear();
            }
            String filepath2 = @"C:\Users\grauk\Desktop\Objectinis programavimas\Raidės\RaidėsFormated.txt";
            File.WriteAllLines(filepath2, Nlines);

        }
    }
}
