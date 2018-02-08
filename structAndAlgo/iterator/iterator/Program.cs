using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
	class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> collection = new List<int>() {1, 2, 3, 4, 5, 6};
			var iter = collection.GetEnumerator();
			while (iter.MoveNext())
			{
				Console.WriteLine(iter.Current);
			}
			Console.ReadKey();
			var backIter = collection.getBackEnumerator();
			while (backIter.MoveNext())
			{
				Console.WriteLine(backIter.Current);
			}
			Console.ReadKey();
			var iter1 = collection.GetEnumerator();
			while (iter1.MoveNext())
			{
				Console.WriteLine(iter1.Current);
			}
			Console.ReadKey();
		}
	}
}
