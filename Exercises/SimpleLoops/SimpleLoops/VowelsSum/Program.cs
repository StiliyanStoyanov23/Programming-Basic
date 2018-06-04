using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var total = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        total += 1;
                        break;
                    case 'e':
                        total += 2;
                        break;
                    case 'i':
                        total += 3;
                        break;
                    case 'o':
                        total += 4;
                        break;
                    case 'u':
                        total += 5;
                        break;
                }
            }
            Console.WriteLine("Vowel sum = " + total);
        }
    }
}
