using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Max();
        }
        public static void Max()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (num1 % 7 == 0)
            {
                Console.WriteLine("Divide by 7");
            }
            else
            {
                for (int i = num1; i < num1 * 2; i++)
                {
                    if (i % 7 == 0)
                    {
                        max = i;
                        Console.WriteLine(max);
                        break;
                    }
                }
                return ;
            }
        }
       
        
    }
}
