using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] sentArray = sentence.Split();
            string checkSent = "";
            string checkSent1 = "";
            foreach (string s in sentArray)
            {
                checkSent += s.Substring(0).ToLower();
            }
            for (int i = 0; i < checkSent.Length; i++)
            {
                checkSent1 += checkSent[checkSent.Length - i - 1];
            }
            if (String.Equals(checkSent, checkSent1))
                Console.WriteLine("Введённое предложение является палиндромом");
            else
                Console.WriteLine("Введённое предложение не является палиндромом");
            Console.ReadKey();
        }
    }
}
