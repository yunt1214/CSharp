using System;

namespace Basic
{
    class CurrencyFormat
    {
        static void Main(string[] args)
        {
            decimal value = 123456.789m;
            Console.WriteLine("잔액은 {0:C2}원 입니다.", value);
            Console.WriteLine("{0,20:C2}원 입니다.", value);
            Console.WriteLine("{0,-20:C2}원 입니다.", value);
            Console.WriteLine("123456789012345678901234567890");
        }
    }
}
