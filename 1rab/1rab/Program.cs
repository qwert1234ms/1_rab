using System;

namespace _1rab
{
    class Program
    {
        static string[] chislo(int n)
        {
            int i;
            int b;
            int q;
            string[] s = new string[20];
            for (i = 0; n > 0; i++)
            {
                b = n;
                n = n / 16;
                q = b - n * 16;

                if (q > 9)
                {
                    if (q == 10)
                    {
                        s[i] = "A";
                        continue;
                    }
                    if (q == 11)
                    {
                        s[i] = "B";
                        continue;
                    }
                    if (q == 12)
                    {
                        s[i] = "C";
                        continue;
                    }
                    if (q == 13)
                    {
                        s[i] = "D";
                        continue;
                    }
                    if (q == 14)
                    {
                        s[i] = "E";
                        continue;
                    }
                    if (q == 15)
                        s[i] = "F";
                }
                else
                {
                    s[i] = Convert.ToString(q);
                }
            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            return s;
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            chislo(a);
            Console.ReadKey();
        }
    }
}