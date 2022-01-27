using System;

namespace GitCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Anna 2 numeroa");
                int num1, num2;
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                int summa = num1 + num2;
                Console.WriteLine(summa);
            }
        }
    }
}
