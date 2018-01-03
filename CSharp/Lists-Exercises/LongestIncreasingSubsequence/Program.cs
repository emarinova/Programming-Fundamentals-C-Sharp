using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];

            len[0] = 1;
            prev[0] = -1;

            for (int i = 1; i < nums.Count; i++)
            {
                int maxlenLoc = 0;
                int coef = -1;
                for (int j = 0; j < i; j++)
                {
                    if(len[j] > maxlenLoc && nums[j] < nums[i])
                    {
                        maxlenLoc = len[j];
                        coef = j;
                    }
                }
                len[i] = maxlenLoc + 1;
                prev[i] = coef;
            }
            //Console.WriteLine(String.Join(" ",len));
            //Console.WriteLine(string.Join(" ",prev));

            List<int> LIS = new List<int>();
            int maxLen = 0;
            for (int i = 0; i < len.Length; i++)
            {
                if (len[i] > len[maxLen])
                {
                    maxLen = i;
                }
            }
            while (maxLen != -1)
            {
                LIS.Add(nums[maxLen]);
                maxLen = prev[maxLen];
            }
            //Console.WriteLine(String.Join(" ",LIS));
            for(int i = LIS.Count - 1; i >=0; i--)
            {
                Console.Write(LIS[i] + " ");
            }



        }
    }
}
