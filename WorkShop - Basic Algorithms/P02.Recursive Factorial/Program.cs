using System;

namespace P02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = Factoriel(n);
            Console.WriteLine(result);
        }
        public static int Factoriel(int n )
        {
            if (n==1)
            {
                return 1;
            }
            return n * Factoriel(n - 1);
        }
    }
}
