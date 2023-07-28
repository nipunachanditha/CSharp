using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.question1();
            p.question2();
            p.question3();
            p.question4();
            p.question5();
        }

        void question1()
        {
            Console.Write("Enter the num 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the num 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Sum = {0} ", num1 + num2);
        }
        void question2()
        {
            Console.Write("Enter the num 1 : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the num 2 : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Summation = {0}", num1 + num2);
            Console.Write("substraction = {0}", num1 - num2);
            Console.Write("Multiplication = {0}", num1 * num2);
            Console.Write("Devision = {0}", num1 / num2);
        }

        void question3()
        {
            Console.Write("Enter the Radius : ");
            int rad = int.Parse(Console.ReadLine());

            Console.Write("Area = {0}", 3.14 * rad * rad);
            Console.Write("Circumference = {0}", 2 * 3.14 * rad);

        }
        void question4()
        {
            Console.Write("Enter the number : ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("The number is Even number");
            }
            else
            {
                Console.Write("The number is ODD number");
            }
        }
        void question5()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter the value {0} : ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.WriteLine("The number {0} is Even number", j);
                }
                else
                {
                    Console.WriteLine("The number {0} is ODD number", j);
                }
            }

        }


    }
}
