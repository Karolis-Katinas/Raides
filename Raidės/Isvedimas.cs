using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raidės
{
    public class Isvedimas
    {
        public static void Output(string path,string nlines)
        {
            string filepath2 = path.Remove(path.Length - 4, 4) + "_converted.txt";
            File.WriteAllText(filepath2, nlines);
        }
    }
}
