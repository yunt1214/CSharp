using System;
namespace UserExceptionApp
{
    class UserErrException : ApplicationException
    {
        public UserErrException(string s) : base(s) { }
    }
    class Program
    {
        public static void Main()
        {
            try
            {
                throw new UserErrException("throw a exception with a message");
            }
            catch (UserErrException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}