using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace braketTest
{
	public class BracketTest
	{

		public static void Main(string[] args)
		{
			OptExp opt = new OptExp();
			string exp = "(3*5)-6/2)";

			Console.WriteLine(exp);

			if (opt.testPair(exp))
			{
				Console.WriteLine("괄호 맞음!!");
			}
			else
			{
				Console.WriteLine("괄호 틀림!!");
			}
		}
	}
}