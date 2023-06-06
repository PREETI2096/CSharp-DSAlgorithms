namespace DSAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problems");
              BubbleSort bubbleSort = new BubbleSort();
              bubbleSort.GetBubbleSort();
           
            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nOriginal Array Elements :");
            InsertionSort.PrintIntegerArray(numbers);
            Console.WriteLine("\nSorted Array Elements after insertion sort :");
           InsertionSort.PrintIntegerArray(InsertionSort.GetInsertionSort(numbers));
            Console.WriteLine("\n");
            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort();
        }

    }
    }
