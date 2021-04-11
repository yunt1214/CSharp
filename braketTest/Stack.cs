using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace braketTest
{
	public interface Stack
	{
		bool isEmpty();
		void push(char item);
		char pop();
		void delete();
		char peek();
	}
}