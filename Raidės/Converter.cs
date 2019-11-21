using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raidės
{
    public class TextConverter
    {
        List<string> text;
        public TextConverter() { }
        public TextConverter(List<string> ntext) { text = ntext; }
        public List<string> ConvertText(List<string> txt)
        {
            List<string> nlines = new List<string> { };
            StringBuilder linija = new StringBuilder { };
            foreach (string Line in txt)
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
            return nlines;
        }
        public List<string> GetText()
        {
            return text;
        }
    }
}
