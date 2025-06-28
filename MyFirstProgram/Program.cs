using System;
using System.Collections.Generic;
using System.Transactions;

namespace MyFirstProgram
{
    class Program
    {
        public static int Main(string[] args)
        {
            while (true)
            {
            Console.Write("How many sets of numbers you want to divide? ");
            int sets = Convert.ToInt32(Console.ReadLine());
            
                
                 for (int i = 1; i <= sets; i++)
                {
                    Console.WriteLine("First Number: ");
                    decimal fnum = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Second Number: ");
                    decimal Snum = Convert.ToDecimal(Console.ReadLine());

                    if (Snum == 0)
                    {
                        Console.WriteLine("You cannot divide by Zero ");
                        Console.WriteLine(" ");
                        break;
                    }

                    decimal results = fnum / Snum;
                    Console.WriteLine("results: " + results.ToString("F2"));
                    Console.WriteLine();


                }
            } 
            
        }
        
     }
}