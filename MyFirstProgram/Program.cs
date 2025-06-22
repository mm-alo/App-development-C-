using System;
using System.Collections.Generic;
using System.Transactions;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Total number of Courses: ");
            int course1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter price of your favorite book: ");
            int book1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name " + name);
            Console.WriteLine("Total number of enrolled courses " + course1);
            Console.WriteLine("Price of your favorite book " + book1);
        }
     }
}