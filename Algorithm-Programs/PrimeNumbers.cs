using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    internal class PrimeNumbers
    {
        public void PrimeNumber()
        {
            Console.Write("\nEnter the stating number : ");
            int startingNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the last number : ");
            int lastNum = Convert.ToInt32(Console.ReadLine());

            for(int i = startingNum; i <= lastNum; i++)
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
                }
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
