using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Check(s) ? "Корректно" : "Некорректно");
            Console.ReadKey();
        }
        static bool Check(string s)
        {
            string brackets = "[{(]})";
            Stack<char> str = new Stack<char>();
            foreach (var i in s)
            {
                int x = brackets.IndexOf(i);
                if (x >= 0 && x <= 2)
                {
                    str.Push(i);
                }
                if (x > 2)
                {
                    if (str.Count == 0 || str.Pop() != brackets[x - 3])
                    {
                        return false;
                    }
                }
            }
            if (str.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
