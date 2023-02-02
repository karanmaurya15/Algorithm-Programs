namespace Algorithm_Programs
{
    internal class Program
    {
        public static string binaryTextPath = @"C:\BridgeLabz\Algorithm-Programs\Algorithm-Programs\Files\BinarySearch.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.BinarySearch \n 2.Exit");
                Console.Write("Select any one from the above option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadFile(binaryTextPath);
                        search.BinarySearchWord("problem");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}