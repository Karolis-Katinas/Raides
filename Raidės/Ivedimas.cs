using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raidės;
using System.IO;

namespace Raidės
{
   public  class Ivedimas
    {
        string path, text;
        public string ivesti()
        {
            do
            {
                Console.WriteLine("Iveskite faila, kuri norite konvertuoti");
                path = Console.ReadLine();
                if ((File.Exists(path)) && (path.EndsWith(".txt")))
                {
                    text = File.ReadAllText(path);
                }
                else Console.WriteLine("Failas neegzistuoja!");
            } while (!(File.Exists(path) && (path.EndsWith(".txt"))));

            return text;
        }
        public string GetPath()
        {
            return path;
        }

    }
}
