using Raidės;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace raides
{
    public class  Program
    {
        public static void Main(string[] args)
        {
            Ivedimas text1 = new Ivedimas();
            string newtext = TextCaseConverter.Convert(text1.ivesti());
            Isvedimas.Output(text1.GetPath(), newtext);
        }
    }
}
