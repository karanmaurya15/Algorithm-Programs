using System;

namespace Algorithm_Programs
{
    internal class Program
    {
        public static string binaryTextPath = @"C:\BridgeLabz\Algorithm-Programs\Algorithm-Programs\Files\BinarySearch.txt";
        static void Main(string[] args)
        {
            int[] array = { 5, 1, 8, 7, 2, 4, 6, 9, 3, 10 };
            int[] ary = { 26, 20, 54, 34, 12, 39, 19, 45 };
            Console.WriteLine("Welcome to the Algorithm Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1.BinarySearch \n 2.InsertionSort \n 3.BubbleSort \n 4.MergeSort \n 5.Anagram Detection \n 6.PrimeNumber \n 7.Exit");
                Console.Write("\nSelect any one from the above option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadFile(binaryTextPath);
                        search.BinarySearchWord("problem");
                        break;
                    case 2:
                        InsertionSort sort = new InsertionSort();
                        sort.ReadTextFiles(binaryTextPath);
                        sort.Sort();
                        break;
                    case 3:
                        BubbleSort bubblesort = new BubbleSort();
                        Console.WriteLine("Before sorting: ");
                        bubblesort.Display(array);
                        bubblesort.Sort(array);
                        break;
                    case 4:
                        MergeSort mergeSort = new MergeSort();
                        Console.WriteLine("Array Before Sorting: ");
                        mergeSort.Display(ary);
                        mergeSort.Merge_Sort(ary, 0, ary.Length - 1);
                        Console.WriteLine("Array after Sorting: ");
                        mergeSort.Display(ary);
                        break;
                    case 5:
                        Anagram check = new Anagram();
                        check.CheckAnagram("heart", "earth");
                        break;
                    case 6:
                        PrimeNumbers primeNumbers = new PrimeNumbers();
                        primeNumbers.PrimeNumber();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}