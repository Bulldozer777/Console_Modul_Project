using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class M_13_Keyword_Params
    {
        public static void Keyword_Params_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 13)
            {
                Keyword_Params_Addition(new int[] { 1, 2, 3, 4 });
                Keyword_Params_Addition(2, 3, 4, 5);
                Keyword_Params_Addition();    //0 т к резалт ноль по умолчанию
                Keyword_Params_Addition_Mas(new int[] { 1, 2, 3, 4 }); // сработает только 1 случай , а не все 3 верхних 
            }
            Program.EndInStart();
        }
        public static void Keyword_Params_Addition(params int[] numbers) // после передачи словом парамс нельзя указывать еще параметры
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            Console.WriteLine(result);
        }
        public static void Keyword_Params_Addition_Mas(int[] numbers) 
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            Console.WriteLine(result);
        }
    }
}
