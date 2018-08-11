using System;

namespace CG_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            int age = Int32.Parse(Console.ReadLine());

            int[] numbers = new int[21]; //using 21 bc it creates an array going from 0-20
            
            for (int i = 2; i <= 20 ; i++) { 

            numbers[i] = age * i;
            }
            for (int i = 2; i <= 20; i++)
            {
                Console.WriteLine(numbers[i]);
                
            }
            Console.ReadLine();
        }
    }
}
