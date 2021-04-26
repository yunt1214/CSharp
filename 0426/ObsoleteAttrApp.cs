using System;
namespace ObsoleteAttrApp
{
    class ObsoleteAttr
    {
        [Obsolete("경고, Obsolete Method입니다.")]
        public static void OldMethod()
        {
            Console.WriteLine("In the Old Method ...");
        }
        public static void NormalMethod()
        {
            Console.WriteLine("In the Normal Method ...");
        }
    }
    class Program
    {
        public static void Main()
        {
            ObsoleteAttr.OldMethod();
            ObsoleteAttr.NormalMethod();
        }
    }
}