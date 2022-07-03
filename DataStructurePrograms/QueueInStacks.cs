using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    internal class QueueInStacks
    {
		public static void DriverMethod()
		{
			QueueInStacks q = new QueueInStacks();
			Console.Write("Enter month: ");
			int m = int.Parse(Console.ReadLine());
			Console.Write("Enter year: ");
			int y = int.Parse(Console.ReadLine());
			Stack<Object> st = q.QueToStack(m, y);
			q.DisplayQueCalender(st);
		}
		public Stack<Object> QueToStack(int m, int y)
		{

			WeekDay w = new WeekDay();
			Queue<Object> q = w.CalenderToQue(m, y);
			Stack<Object> st = new Stack<Object>(q.Size());
			while (q.Size() != 0)
			{
				st.Push(q.Dequeue());
			}
			return st;
		}
		public void DisplayQueCalender(Stack<Object> obj)
		{
			for (int i = 0; i < 7; i++)
			{
				Week O = (Week)obj.Pop();
				int[] a = O.list.ToArray();
				Console.Write("{0,10}  ", O.week);
				for (int j = 0; j < a.Length; j++)
				{
					if (a[j] == 0) Console.Write("{0,2} ", ' ');
					else Console.Write("{0,2} ", a[j]);
				}
				Console.WriteLine();
			}

		}
	}
}
