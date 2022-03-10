using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> prueba = new Dictionary<string, string>();

            prueba.Add("A","Prueba A");
            prueba.Add("B", "Prueba B");
            prueba.Add("C", "Prueba C");
            prueba.Add("D", "Prueba D");
            prueba.Add("E", "Prueba E");
            prueba.Add("F", "Prueba F");
            prueba.Add("G", "Prueba G");
            prueba.Add("H", "Prueba H");
            prueba.Add("I", "Prueba I");
            prueba.Add("J", "Prueba J");
            string keis;
            var keys = string.Join(",", prueba.Keys.ToArray());

        }
    }
}
