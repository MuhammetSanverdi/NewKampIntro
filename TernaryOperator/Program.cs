using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100, y = 100;
            string result = x > y ? "X yden büyüktür" :
                x < y ? "X yden küçüktür" :
                x == y ? "X ye eşittir" : "no result";
            Console.WriteLine(result);
        }
    }
}
