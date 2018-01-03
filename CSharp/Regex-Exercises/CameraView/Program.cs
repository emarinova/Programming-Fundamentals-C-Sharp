using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            int imgsToSkip = int.Parse(data[0]);
            int imgsToTake = int.Parse(data[1]);

            string input = Console.ReadLine();

            string[] cameras = Regex.Split(input, @"\|<");
            List<string> takenElements = new List<string>();
            for (int i = 1; i < cameras.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                int indexer = 0;
                while (indexer < cameras[i].Length)
                {
                    if(indexer<imgsToSkip)
                    {
                        indexer++;
                    }
                    else if(indexer>=imgsToSkip && indexer<imgsToSkip + imgsToTake)
                    {
                        sb.Append(cameras[i][indexer]);
                        indexer++;
                    }
                    else if(indexer>= imgsToSkip+imgsToTake)
                    {
                        break;
                    }
                }
                takenElements.Add(sb.ToString());
            }
            Console.WriteLine(string.Join(", ", takenElements));
        }
    }
}
