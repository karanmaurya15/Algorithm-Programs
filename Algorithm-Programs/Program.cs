using System;

namespace Algorithm_Programs
{
    internal class Program
    {
        public static string binaryTextPath = @"C:\BridgeLabz\Algorithm-Programs\Algorithm-Programs\Files\BinarySearch.txt";
        static void Main(string[] args)
        {
            int[] array = { 5, 1, 8, 7, 2, 4, 6, 9, 3, 10 };
            Console.WriteLine("Welcome to the Algorithm Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1.BinarySearch \n 2.InsertionSort \n 3.BubbleSort \n 4.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}