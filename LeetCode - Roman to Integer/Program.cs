using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXCIV";
            int result = RomanToInt(roman);
            Console.WriteLine($"Input: {roman} output: {result}");
            Console.ReadLine();

        }
        static int RomanToInt(string s)
        {
            char[] romanArray = s.ToCharArray();
            int output = 0;
            for(int i = 0;i< romanArray.Length;i++)
            {
                char next = 'Z';
                if(!(i>=romanArray.Length))
                {
                    next = romanArray[i + 1];
                }
                switch(romanArray[i])
                {
                    case 'I':
                        if (next == 'V')
                        {
                            output += 4;
                            i++;
                        }
                        else if (next == 'X')
                        {
                            output += 9;
                            i++;
                        }
                        else
                            output += 1;
                        break;
                    case 'V':
                        output += 5;
                        break;
                    case 'X':
                        if (next == 'L')
                        {
                            output += 40;
                            i++;
                        }
                        else if (next == 'C')
                        {
                            output += 90;
                            i++;
                        }
                        else
                            output += 10;
                        break;
                    case 'L':
                        output += 50;
                        break;
                    case 'C':
                        if (next == 'D')
                        {
                            output += 400;
                            i++;
                        }
                        else if (next == 'M')
                        {
                            output += 900;
                            i++;
                        }
                        else
                            output += 100;
                        break;
                    case 'D':
                        output += 500;
                        break;
                    case 'M':
                        output += 1000;
                        break;
                    default:
                        break;
                }
            }

            return output;
        }
    }
}
