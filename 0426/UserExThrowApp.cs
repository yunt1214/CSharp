using System;
namespace UserExThrowApp
{
    class UserException : ApplicationException { }
    class Program
    {
        static void Method()
        {
            throw new UserException();
        }
        public static void Main()
        {
            try
            {
                Console.WriteLine("Here: 1");
                Method();
                Console.WriteLine("Here: 2");
            }
            catch (UserException)
            {
                Console.WriteLine("User-defined Exception");
            }
        }
    }
}