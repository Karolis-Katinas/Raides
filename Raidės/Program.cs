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
                    if ((Symbol >= 'A' && Symbol <= 'Z') || (Symbol == 'Ą') || (Symbol == 'Č') || (Symbol == 'Ę') || (Symbol == 'Ė') || (Symbol == 'Į') || (Symbol == 'Š') || (Symbol == 'Ų') || (Symbol == 'Ū') || (Symbol == 'Ž'))
                    {
                        linija.Insert(i, char.ToLower(Symbol));
                    }

                    else if ((Symbol >= 'a' && Symbol <= 'z') || (Symbol == 'ą') || (Symbol == 'č') || (Symbol == 'ę') || (Symbol == 'ė') || (Symbol == 'į') || (Symbol == 'š') || (Symbol == 'ų') || (Symbol == 'ū') || (Symbol == 'ž'))
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
