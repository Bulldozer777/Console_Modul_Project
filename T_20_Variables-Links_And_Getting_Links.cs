using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class T_20_Variables_Links_And_Getting_Links : Modul_Struct
    {
        public static void Variables_Info(int a)
        {
            if (a == 20)
            {
                Modul_Struct twenty = new T_20_Variables_Links_And_Getting_Links();
                Modul_Struct_Start_With_DB(a, twenty,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1)),
                    NameCreate1_p: "try ... catch ... finally \nОбщий тип исключений Exception",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "Возвращение ссылки из метода Variables_Links",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    //NameCreate3_p: "Ввод с консоли до 6 символов, иначе генерируется исключение",
                    //OperationCreate3_p: Code_Writer_Console(a, 4),
                    //NameCreate4_p: "Кортеж string и int",
                    //OperationCreate4_p: Code_Writer_Console(a, 6),
                    NameExamples1_p: "",
                    OperationExamples1_p: Code_Writer_Console(a, 6)
                    );                         
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            int x = 5;
            ref int xRef = ref x;
            //переменная хRef указывает на туже область в памяти, где храниться переменная х
            //через хRef мы можем манипулировать значением переменной х
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"xRef = {xRef}");
            xRef = 125;
            Console.WriteLine($"x = {x}");
            Console.WriteLine("\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int nRef = ref Variables_Links(numbers, 4);
            //элемент массива numbers по 3 индексу
            //numbers[3]
            Console.WriteLine(Variables_Links(numbers, 5));
            Console.WriteLine(numbers[3]);
            nRef = 45;
            Console.WriteLine(numbers[3]);
            //поменяли элемент в массиве т к nRef = 45;
            //и указывает на тоже место в памяти что и элемент массива numbers[3]
            Console.WriteLine("\n");
        }
        public static ref int Variables_Links(int[] numbers, int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("число не найдено");
            //не все ветви кода возвращают значение
            //поэтому сгенерируем исключение
            //передав в конструктор Exception("число не найдено")
        }
    }
}
