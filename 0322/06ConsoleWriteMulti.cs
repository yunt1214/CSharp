using System;

namespace Basic
{
    class ConsoleWriteMulti
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            string primes;
            primes = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
