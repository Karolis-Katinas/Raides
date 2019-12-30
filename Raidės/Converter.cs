using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raidės
{
    public class TextCaseConverter
    {
        string text;
        public TextCaseConverter() { }
        public TextCaseConverter(string ntext) { text = ntext; }
        public static string Convert(string txt)
        {
            string newtext;
            StringBuilder strignbuilder = new StringBuilder { };
                int i = 0;
                foreach (char symbol in txt)
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
            newtext = strignbuilder.ToString();
            return newtext;
        }
        public string GetText()
        {
            return text;
        }
    }
}
