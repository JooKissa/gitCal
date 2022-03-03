using System;

namespace GitCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("joo");
                int num1, num2;
                String thing1;
                num1 = Convert.ToInt32(Console.ReadLine());
                thing1 = Convert.ToString(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                if (thing1 == "+")
                {
                    int summa = num1 + num2;
                    Console.WriteLine(summa);
                }
                else if (thing1 == "-")
                {
                    int summa = num1 - num2;
                    Console.WriteLine(summa);
                }
                else if (thing1 == "*")
                {
                    int summa = num1 * num2;
                    Console.WriteLine(summa);
                }
                else if (thing1 == "/")
                {
                    int summa = num1 / num2;
                    Console.WriteLine(summa);
                }
            }
        }
    }
}
