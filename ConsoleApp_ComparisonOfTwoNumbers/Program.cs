using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_ComparisonOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = 0;
                int n1 = 0;
                bool st1 = false;
                do
                {
                    Write("Enter first number: ");
                    int num1 = int.Parse(ReadLine());
                    n = num1;
                    n1 = num1;

                    st1 = false;
                    while (num1 > 0)
                    {
                        int z1 = 0;
                        int t1;
                        int y1 = num1 % 10;
                        t1 = num1 / 10;
                        while (t1 > 0)
                        {
                            z1 = t1 % 10;
                            if (y1 == z1)
                            {
                                st1 = true;
                            }
                            t1 = t1 / 10;
                        }
                        num1 = num1 / 10;
                    }
                    if (st1 == true)
                    {
                        WriteLine("There is repeated digits in the first number, try again ");
                    }
                } while (st1 == true);

                int m = 0;
                int m1 = 0;
                bool st2 = false;
                do
                {
                    Write("Enter second number: ");
                    int num2 = int.Parse(ReadLine());
                    m = num2;
                    m1 = num2;

                    st2 = false;
                    while (num2 > 0)
                    {
                        int z2 = 0;
                        int t2;
                        int y2 = num2 % 10;
                        t2 = num2 / 10;
                        while (t2 > 0)
                        {
                            z2 = t2 % 10;
                            if (y2 == z2)
                            {
                                st2 = true;
                            }
                            t2 = t2 / 10;
                        }
                        num2 = num2 / 10;
                    }
                    if (st2 == true)
                    {
                        WriteLine("There is repeated digits in the second number, try again ");
                    }
                } while (st2 == true);

                int a1 = 0;
                do
                {
                    n = n / 10;
                    a1 = a1 + 1;
                } while (n > 0);

                int[] b1 = new int[a1];

                for (int i = b1.Length - 1; i >= 0; i--)
                {
                    b1[i] = n1 % 10;
                    n1 = n1 / 10;
                }

                int a2 = 0;
                do
                {
                    m = m / 10;
                    a2 = a2 + 1;
                } while (m > 0);

                int[] b2 = new int[a2];

                for (int i = b2.Length - 1; i >= 0; i--)
                {
                    b2[i] = m1 % 10;
                    m1 = m1 / 10;
                }

                int hamynknum = 0;
                int dirq = 0;
                if (b1.Length <= b2.Length)
                {
                    for (int i = 0; i < b1.Length; i++)
                    {
                        for (int y = 0; y < b2.Length; y++)
                        {
                            if (b1[i] == b2[y])
                            {
                                hamynknum++;
                                if (b1[i] == b2[i])
                                {
                                    dirq++;
                                }
                            }
                        }
                    }
                    WriteLine($"Same digit {hamynknum} : Same position {dirq}");
                }
                else
                {
                    for (int i = 0; i < b2.Length; i++)
                    {
                        for (int y = 0; y < b1.Length; y++)
                        {
                            if (b2[i] == b1[y])
                            {
                                hamynknum++;
                                if (b2[i] == b1[i])
                                {
                                    dirq++;
                                }
                            }
                        }
                    }
                    WriteLine($"Same digit {hamynknum} : Same position {dirq}");
                }
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
