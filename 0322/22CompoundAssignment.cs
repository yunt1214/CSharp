using System;

namespace Basic
{
    class CompoundAssignment
    {
        static void Main(string[] args)
        {
            int x = 32;
            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 8);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);
            Console.WriteLine(x++);
            Console.WriteLine(--x);
        }
    }
}