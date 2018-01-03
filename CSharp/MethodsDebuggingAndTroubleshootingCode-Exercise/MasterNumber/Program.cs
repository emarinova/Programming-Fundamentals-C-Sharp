using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static bool IsPalindrome(int num)
        {

            int numReversed=num%10;
            int n = num / 10;
            while (n> 0)
            {
                numReversed = numReversed*10 + n % 10;
                n /= 10;
            }
            if (num == numReversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while(num >0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static bool ContainsEvenDigit(int num)
        {
            bool isIt = false;
            while(num>0)
            {
                if((num%10)%2==0)
                {
                    isIt = true;
                }
                num /= 10;
            }
            return isIt;
        }

        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            for(int i = 1; i<= endOfRange; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i)%7==0 && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
