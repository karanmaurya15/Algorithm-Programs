using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    internal class PrimeNumbers
    {
        public List<int> primeNumbers = new List<int>();
        public List<int> primePalindrome = new List<int>();
        public List<int> primeAnagram = new List<int>();
        public void PrimeNumber()
        {
            Console.Write("\nEnter the stating number : ");
            int startingNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the last number : ");
            int lastNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPime Numbers between given range are:");
            for (int i = startingNum; i <= lastNum; i++)
            {
                int count = 0;
                for(int j = 2; j <= i/2; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if(count == 0 && i != 1)
                {
                    Console.Write(i + " ");
                    primeNumbers.Add(i);
                }
            }
        }
        public void CheckAnagramPalindrome()
        {
            foreach (var data in primeNumbers)
            {
                if (data > 9)
                {
                    int sum = 0;
                    int remainder;
                    int temp = data;
                    while (temp > 0)
                    {
                        remainder = temp % 10;
                        sum = sum * 10 + remainder;
                        temp /= 10;
                    }
                    if (sum == data)
                        primePalindrome.Add(data);
                }
            }
            Console.WriteLine("\n\nPrime Numbers that are Palindrome between given range are: ");
            Display(primePalindrome);
        }
        public void Display(List<int> list)
        {
            foreach (var data in list)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
