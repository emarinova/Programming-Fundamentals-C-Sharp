using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<p>(.*?)(<\/p>)";
            MatchCollection encriptedMessages = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match message in encriptedMessages)
            {
                var partlyEncripted = Regex.Replace(message.Groups[1].Value, @"[^a-z0-9]", " ");
                partlyEncripted = Regex.Replace(partlyEncripted, @" {2,}", " ");
                StringBuilder encripted = new StringBuilder();
                for (int i = 0; i < partlyEncripted.Length; i++)
                {
                    if (partlyEncripted[i] >= 'a' && partlyEncripted[i] <= 'm')
                    {
                        encripted.Append((char)(partlyEncripted[i] + 13));
                    }
                    else if (partlyEncripted[i] >= 'n' && partlyEncripted[i] <= 'z')
                    {
                        encripted.Append((char)(partlyEncripted[i] - 13));
                    }
                    else if (partlyEncripted[i] == ' ')
                    {
                        encripted.Append(' ');
                    }
                }

                //partlyEncripted = Regex.Replace(partlyEncripted, @"[a-z]", (s) =>
                //{
                //    switch (s.Value)
                //    {
                //        case "a":
                //            return "n";
                //            break;
                //        case "b":
                //            return "o";
                //            break;
                //        case "c":
                //            return "p";
                //            break;
                //        case "d":
                //            return "q";
                //            break;
                //        case "e":
                //            return "r";
                //            break;
                //        case "f":
                //            return "s";
                //            break;
                //        case "g":
                //            return "t";
                //            break;
                //        case "h":
                //            return "u";
                //            break;
                //        case "i":
                //            return "v";
                //            break;
                //        case "j":
                //            return "w";
                //            break;
                //        case "k":
                //            return "x";
                //            break;
                //        case "l":
                //            return "y";
                //            break;
                //        case "m":
                //            return "z";
                //            break;
                //        case "n":
                //            return "a";
                //            break;
                //        case "o":
                //            return "b";
                //            break;
                //        case "p":
                //            return "c";
                //            break;
                //        case "q":
                //            return "d";
                //            break;
                //        case "r":
                //            return "e";
                //            break;
                //        case "s":
                //            return "f";
                //            break;
                //        case "t":
                //            return "g";
                //            break;
                //        case "u":
                //            return "h";
                //            break;
                //        case "v":
                //            return "i";
                //            break;
                //        case "w":
                //            return "j";
                //            break;
                //        case "x":
                //            return "k";
                //            break;
                //        case "y":
                //            return "l";
                //            break;
                //        case "z":
                //            return "m";
                //            break;
                //        default:
                //            return "?";
                //            break;
                //
                //
                //    }
                //});
                sb.Append(encripted.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
