using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 54, 6, 5, 7, 1, 2, 8, 9 };
            QuickSort(arr);
            foreach(var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.ReadKey();


        }
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length-1);
        }
        public static void QuickSort(int []array,int left,int right)
        {
            foreach(var el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            int i = left, j = right;
            int pivit = array[(left + right) >> 1];
            while (i <= j)
            {
                while (array[i] < pivit)
                {
                    i++;
                }
                while (array[j] >pivit)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
                if (left < j)
                {
                    QuickSort(array, left, j);
                }
                if (i < right)
                {
                    QuickSort(array, i, right);
                }
            }
        }
    }
}
