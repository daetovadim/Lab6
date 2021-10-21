using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] array = sentence.Split();
            int lengthMax = 0;
            string longestWord = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > lengthMax)
                {
                    lengthMax = array[i].Length;
                    longestWord = array[i];
                }
            }
            Console.WriteLine($"Самое длинное слово в предложении \"{longestWord}\", состоящее из {lengthMax} символов");
            Console.ReadKey();
        }
    }
}
