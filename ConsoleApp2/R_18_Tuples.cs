using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class R_18_Tuples
    {
        public static void TuplesInfo(int a)
        {
            Program.ModulRegistr(a);
            if (a == 18)
            {
                var tuple = (5, 10); //определение кортежа 
                //использовали неявную типизацию
                (int, int) tuple1 = (5,10); //явная типизация //имена в данном случае явнро не задаются
                var tuple2 = (count: 5, sum: 10);
                Console.WriteLine(tuple2.count);
             //   Console.WriteLine(tuple1.co);
                Console.WriteLine(tuple.Item1); // вывод элементов по имени по умолчанию Item
                Console.WriteLine(tuple.Item2);

                tuple.Item1 += 20; //увеличение элемента кортежа на 20;
                Console.WriteLine(tuple.Item1);
                TuplesCreate(); //вывод значений кортежа по имени переменных
                var tuple3 = GetValue_Tuples();
                Console.WriteLine(tuple3.Item1); //1
                Console.WriteLine(tuple3.Item2);   //3
                var tuple4 = GetValue_Tuples1(("tom", 30), 10); //tom 40
                Console.WriteLine(tuple4);
            }
            Program.EndInStart();
        }
        public static void TuplesCreate()
        {
            var (name, age) = ("Tom", 25);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
        public static (int, int) GetValue_Tuples()
        {
            int result = 1;
            int result2 = 3;
            return (result, result2); //кортеж представляет способ возвращения сразу нескольких значений

        }
        public static (string, int) GetValue_Tuples1((string, int) tuple, int x) //надо изменить чиловое значение параметра кортежа int на значение int x
        {

            var result = (name:tuple.Item1,age:tuple.Item2 + x);
            return result;

        }
    }
}
