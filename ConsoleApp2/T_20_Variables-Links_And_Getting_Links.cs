using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class T_20_Variables_Links_And_Getting_Links
    {
        public static void Variables_Info(int a)
        {
            if (a == 20)
            {
                int x = 5;
                ref int xRef = ref x; //переменная хRef указывает на туже область в памяти, где храниться переменная х
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"xRef = {xRef}");
                xRef = 125;
                Console.WriteLine($"x = {x}");
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
                ref int nRef = ref Variables_Links(numbers, 4); //элемент массива numbers по 3 индексу
                Console.WriteLine(Variables_Links(numbers, 5));
                Console.WriteLine(numbers[3]);
                nRef = 45;
                Console.WriteLine(numbers[3]);


            }
            Generation_Operation.EndInStart();
        }
        public static ref int Variables_Links(int[] numbers, int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] ==number)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("число не найдено"); 
        }
    }
}
