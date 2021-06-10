using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class K_11_Methods : Modul_Struct
    {
        public static void K_11_Methods_Info(int a)
        {
            if (a == 11)
            {
                Modul_Struct Eleven = new K_11_Methods();   //нужно создавать объект класса наследника, после ключевого слова new
                operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                name_Create_Method_1 = "Виды методов - void, int, string; модификатор static";
                operation_Create_Method_1 = Code_Writer_Console(a, 2);
                name_Examples_Method_1 = "Метод на вывод массива FizzBizz";
                operation_Examples_Method_1 = Code_Writer_Console(a, 3);
                Eleven.Method_Modul_Start_1();
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            K_11_Methods_Create();
        }
        public override void Coddition_Examples_Type_Method_1()
        {
            FizzBizz(Mas_for_FizzBizz());
        }
        public static void K_11_Methods_Create()
        {
            Method1();
            Method2(); //метод Method2 надо сделать static , иначе он не доступен в public static void K_11_Methods_Create()
                       //и любом другом статическом методе
            string s = Hello();
            Console.WriteLine(s);
            int c = Sum();
            Console.WriteLine(c);
        }
        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
        static string Hello() //Такой метод называется функцией, который возвращает значение
        {
            return "hello world!";
        }
        static int Sum() //Такой метод называется функцией, который возвращает значение
        {
            int x = 2;
            int y = 3;
            int z = x + y;
            return z;
        }
        public static int[] Mas_for_FizzBizz()
        {
            int[] news = new int[10];// {1, 2,5,6,4,2,6,8,9,20};
            return news;
        }
        public static void FizzBizz(int[] news)
        {
            for (int i = 1; i < news.Length; i++)
            {
                news[i] = i;
            }
            foreach (int news1 in news)
            {
                if ((news1 + 1) % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if ((news1 + 1) % 5 == 0)
                {
                    Console.WriteLine("bizz");
                }
                else
                {
                    Console.WriteLine(news1 + 1);
                }
            }
        }
    }
}
