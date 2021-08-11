using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class M_13_Keyword_Params : Modul_Struct
    {
        public static void Keyword_Params_Info(int a)
        {
            if (a == 13)
            {
                Modul_Struct Thirteen = new M_13_Keyword_Params();   //нужно создавать объект класса наследника, после ключевого слова new
                Thirteen.Operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                Thirteen.Name_Create_Method_1 = "Ключевое слово Params";
                Thirteen.Operation_Create_Method_1 = Code_Writer_Console(a, 2);
                Thirteen.Name_Examples_Method_1 = "Метод на вывод массива FizzBizz";
                Thirteen.Operation_Examples_Method_1 = Code_Writer_Console(a, 3);
                Thirteen.Method_Modul_Start_1(a);
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Examples_Type_Method_1()
        {
            FizzBizzParams_Mas();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Keyword_Params_Start();
        }
        public static void Keyword_Params_Start()
        {
            Keyword_Params_Addition(new int[] { 1, 2, 3, 4 });
            Keyword_Params_Addition(2, 3, 4, 5);
            Keyword_Params_Addition();    
            //0 т к резалт ноль по умолчанию
            Keyword_Params_Addition_Mas(new int[] { 1, 2, 3, 4 }); 
            // сработает только 1 случай , а не все 3 верхних 
        }
        public static void Keyword_Params_Addition(params int[] numbers) 
            // после передачи словом парамс нельзя указывать еще параметры
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
        //public static void Coddition_Examples_Type_Method()
        //{
        //    Console.WriteLine("метод");
        //}
        static void FizzBizzParams(params string[] integers)
        {
            string result = "fizz";
            string result_1 = "bizz";
            for (int i = 0; i < integers.Length; i++)
            {
                if (Convert.ToInt32(integers[i]) % 3 == 0)
                {
                    Console.WriteLine($"{result} ");
                    continue;
                }
                if (Convert.ToInt32(integers[i]) % 5 == 0)
                {

                    Console.WriteLine($"{result_1} ");
                }
                else
                {
                    Console.WriteLine($"{integers[i]} ");
                }
            }
        }
        static void FizzBizzParams_Mas()
        {
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = i + 1;
                FizzBizzParams(Convert.ToString(a[i]));
            }
        }
    }
}
