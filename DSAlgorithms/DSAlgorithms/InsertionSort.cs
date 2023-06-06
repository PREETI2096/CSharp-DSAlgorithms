using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    internal class InsertionSort
    {
        public static int[] GetInsertionSort(int[] inputArray)
        {

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

       public static void PrintIntegerArray(int[] array) { 
            
                foreach (int i in array)
                {
                    Console.Write(i.ToString() + "  ");
                }
            }
    }
    }
