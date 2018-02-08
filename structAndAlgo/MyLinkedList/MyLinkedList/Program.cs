using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(1, 2, 23, 4, 3, 7);
            foreach(var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            list.Insert(20, 555);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
