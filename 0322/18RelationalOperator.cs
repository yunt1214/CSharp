using System;

namespace Basic
{
    class RelationalOperator
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;
            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);
            result = (first > second);
            Console.WriteLine("{0} > {1} : {2}", first, second, result);
            result = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, result);
            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);
            result = (first <= second);
            Console.WriteLine("{0} <= {1} : {2}", first, second, result);
            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);
        }
    }
}