using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raidės
{
    public class TextCaseConverter
    {
        List<string> text;
        public TextCaseConverter() { }
        public TextCaseConverter(List<string> ntext) { text = ntext; }
        public static List<string> ConvertText(List<string> txt)
        {
            List<string> newtext = new List<string> { };
            StringBuilder strignbuilder = new StringBuilder { };
            foreach (string Line in txt)
            {

                int i = 0;
                foreach (char symbol in Line)
                {
                    if (Char.IsUpper(symbol))
                    {
                        strignbuilder.Insert(i, char.ToLower(symbol));
                    }

                    else if (Char.IsLower(symbol))
                    {
                        strignbuilder.Insert(i, char.ToUpper(symbol));
                    }
                    else
                    {
                        strignbuilder.Insert(i, symbol);
                    }
                    i++;
                }
                newtext.Add(strignbuilder.ToString());
                strignbuilder.Clear();
            }
            return newtext;
        }
        public List<string> GetText()
        {
            return text;
        }
    }
}
