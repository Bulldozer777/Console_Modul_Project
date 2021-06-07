using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class L_12_Method_Parameters
    {
        public static void Method_Parameters(int a)
        {
            Program.ModulRegistr(a);
           // Console.WriteLine("Модуль 12");
           // Console.WriteLine("Параметры метода");
            if (a == 12)
            {
                int z = 5;
                int d = 6;
                Console.WriteLine($"Intermal value z = {z}"); //5
                AdditionVal(z, d); //11   Метод создает копию переменной z в памяти и работает с копией , переменная z после отработки метода не меняет свое значение
                Console.WriteLine($"AdditionVal z = {z}"); //5
                AdditionRef(ref z, d); //11 Метод работает с самой переменной z и переменная z после отработки метода меняет свое значение  ,
                                       //ref передача значения по ссылке,
                                       //ключевое слово ref ставиться в параметрах метода и при работе(выводе) метода в месте объявления параметров
                Console.WriteLine($"AdditionRef z = {z}"); //11
                int area;
                int perimeter;
                GetData(12, 130, out area, out perimeter);   //выходные параметры заданы не return, а ключевым словом out,
                                                             //созданы пустые переменные такие же как и в методе и заполены результатом выполнения метода   
                Console.WriteLine($"Area - {area}");
                Console.WriteLine($"Perimeter - {perimeter}");
                Console.WriteLine("Необязательные параметры");
                int d1 = Optional(x:1,y: 2,z:3,s:4) ; // Именованные параметры x:2 , происходит указание какому именно параметру мы присваиваем значение,
                                                      // могут идти не по порядку, можем  изменить порядок передачи значений параметрам,
                                                      // по умолчанию они(параметры) передаются по позиции
                int d2 = Optional(1, 2, 3); 
                int d3 = Optional(1, 2); // параметры заданы в методе по умолчанию, так что их можно не заполнять и они заполняться теми,
                                         // что указаны в методы при его объявлении
                Console.WriteLine(d1); //10
                Console.WriteLine(d2); //13
                Console.WriteLine(d3); //15

                Console.WriteLine("Именованные параметры");


                Program.EndInStart();
            }
        }
        public static void AdditionRef(ref int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionRef x = {x}");
                

        }
        public static void AdditionVal(int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionVal x = {x}");

        }
        public static void GetData(int width, int height, out int area, out int perimeter)
        {
            perimeter = (width + height) * 2;
            area = width * height;

        }
        public static int Optional(int x, int y,  int z = 5,  int s = 7)
        {
            return x + y + z + s;

        }
        public static int Optional1(int x, int y, int z = 5, int s = 7)
        {
            return x + y + z + s;

        }
    }
}
