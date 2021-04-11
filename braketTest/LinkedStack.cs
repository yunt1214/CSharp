using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace braketTest
{
	public class LinkedStack : Stack
	{
		private StackNode top;

		public bool isEmpty()
		{
			return (top == null);
		}

		public virtual void push(char item)
		{
			StackNode newNode = new StackNode();
			newNode.data = item;
			newNode.link = top;
			top = newNode;
			// System.out.println("Inserted Item : " + item);
		}

		public virtual char pop()
		{
			if (isEmpty())
			{
				Console.WriteLine("Deleting fail! Linked Stack is empty!!");
				return (char)0;
			}
			else
			{
				char item = top.data;
				top = top.link;
				return item;
			}
		}

		public virtual void delete()
		{
			if (isEmpty())
			{
				Console.WriteLine("Deleting fail! Linked Stack is empty!!");

			}
			else
			{
				top = top.link;
			}
		}

		public virtual char peek()
		{
			if (isEmpty())
			{
				Console.WriteLine("Peeking fail! Linked Stack is empty!!");
				return (char)0;
			}
			else
			{
				return top.data;
			}
		}

		public virtual void printStack()
		{
			if (isEmpty())
			{
				Console.Write("Linked Stack is empty!! %n %n");
			}
			else
			{
				StackNode temp = top;
				Console.WriteLine("Linked Stack>> ");
				while (temp != null)
				{
					Console.Write("\t {0} \n", temp.data);
					temp = temp.link;
				}
				Console.WriteLine();
			}
		}
	}
}