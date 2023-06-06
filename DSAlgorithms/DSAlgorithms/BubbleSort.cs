using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    internal class BubbleSort
    {
        public void GetBubbleSort()
        {
            int[] a = { 9, 20, 55, 79, 44, 68, 66, 54, 35, 37, 25 };

            // for loop for printing the elements of an array
            Console.WriteLine("Elements of array are :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i] + " ");
            }
            // nested for loop for bubble sort operation
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nElements of array after bubble sort is :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i] + " ");
            }
        }
    }
}