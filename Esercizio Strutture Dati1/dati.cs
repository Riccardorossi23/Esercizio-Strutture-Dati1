using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Strutture_Dati1
{
    class dati
    {
        static void Main(string[] args)
        {
            List<double> numeri = new List<double>();
            using (StreamReader sr = new StreamReader("fileDati.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double f = Convert.ToDouble(line);
                }
            }
            using (StreamWriter sw = new StreamWriter("copiafile.txt", true))
            {
                for (int i = numeri.Count - 1; i >= 0; i--)
                {
                    sw.WriteLine(numeri[i]);

                }
            }
        }
    }
}
