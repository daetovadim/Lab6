using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();            
            for (int i = 0, j = 0; i < S.Length && j < S.Length;)
            {                
                i = S.IndexOf('{');
                j = S.IndexOf('}');
                if (i == -1)
                    break;
                S = S.Remove(i, j - i + 1);
            }
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
