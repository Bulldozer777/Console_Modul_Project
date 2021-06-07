using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class O_15_Recursive_Functions
    {
        public static void Recursive_Functions_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 15)
            {
                int y = Factorial(10);
                int e = 1;
                Console.WriteLine(y);
                Console.WriteLine(e);
                int p = Fibbonacci(21);
                Console.WriteLine(p);

            }
            Program.EndInStart();
        }
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int z = n * Factorial(n - 1);    //Factorial(5) = 5 * Factorial(4) = 5 * 4 * Factorial(3).;.. = 5 * 4 * 3 * 2 * 1 * 1 ;
                return z;
            }
        }
        public static int Fibbonacci(int n)
        {
            if (n == 0 )
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }
            else
            {
                int z = Fibbonacci(n - 1)+ Fibbonacci(n - 2);   
                return z;
            }
        }
        public static void Display()
        {
            //public static void Recursive_Functions_Info(int a)
            //{
            //    Program.ModulRegistr(a);
            //    if (a == 15)
            //    {

            //    }
            //    Program.EndInStart();
            //}
            //public static void Display()
            //{
            //}
        }
        
    }
}
