using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_A_27_Overloading_Methods
    {
        public static void Z_A_27_Overloading_Methods_Info(int a)
        {
            if (a == 27)
            {
                //3 версии методов
                Z_A_27_Add(2, 4);
                Z_A_27_Add(2, 4,6);
                Z_A_27_Add(2, 4.5);
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_A_27_Overloading_Methods_Create(int a)
        {
           
        }
        public static void Z_A_27_Add(int x, int y)  //методы работают, с одним и тем же именем, если различаются по типу параметров или их количеству, 
            //назвается версия метода
        {
            int result = x + y;
            Console.WriteLine($"Result - {result}");
        }
        public static void Z_A_27_Add(int x, int y, int z)
        {
            int result = x + y + z;
            Console.WriteLine($"Result - {result}");
        }
        public static void Z_A_27_Add(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"Result - {result}");
        }
        //public static int Z_A_27_Add(int x, int y)   ошибка 
        //{
        //    int result = x + y;
        //    Console.WriteLine($"Result - {result}");
        //    return x + y;
        //}
    }
}
