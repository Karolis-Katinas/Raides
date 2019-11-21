using Raidės;
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
            Ivedimas i = new Ivedimas();
            TextConverter n = new TextConverter();
            Isvedimas s = new Isvedimas();
            List<string> oldtext, newtext;
            string path;
            oldtext = i.ivesti();
            newtext=n.ConvertText(oldtext);
            path = i.GetPath();
            s.isvedimas(path, newtext);
        }
    }
}
