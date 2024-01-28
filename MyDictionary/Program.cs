using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>() { };
            dictionary.Add(1, "Engin");
            dictionary.Add(2, "Kerem");
            dictionary.Add(3, "Halil");

            for (int i = 0; i < dictionary.KLenght; i++)
            {
                Console.WriteLine(dictionary.TitleK[i] + " numaralı kişi: " + dictionary.TitleV[i]);
            }
            Console.ReadKey();
        }
    }
}