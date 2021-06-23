using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class R_18_Tuples : Modul_Struct
    {
        public static void TuplesInfo(int a)
        {
            if (a == 18)
            {
                Modul_Struct eighteen = new R_18_Tuples();
                Modul_Struct_Start_With_DB(a, eighteen,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1)),
                    NameCreate1_p: "Определение кортежа",
                    OperationCreate1_p: Code_Writer_Console(a, 3),
                    NameCreate2_p: "Вывод значений кортежа по имени переменных",
                    OperationCreate2_p: Code_Writer_Console(a, 4),
                    NameCreate3_p: "Метод, возвращающий кортеж",
                    OperationCreate3_p: Code_Writer_Console(a, 5),
                    NameCreate4_p: "Кортеж string и int",
                    OperationCreate4_p: Code_Writer_Console(a, 6),
                    NameExamples1_p: "",
                    OperationExamples1_p: Code_Writer_Console(a, 6)
                    ) ;
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            var tuple = (5, 10); //определение кортежа 
                                 //использовали неявную типизацию
            (int, int) tuple1 = (5, 10); 
            //явная типизация //имена в данном случае явнро не задаются
            var tuple2 = (count: 5, sum: 10);
            //присвоение названия
            Console.WriteLine(tuple2.count);
            Console.WriteLine($"{tuple1.Item1} - {tuple1.Item2}" );
            //вывод кортежа tuple1 c явной типизацией
            Console.WriteLine(tuple.Item1); 
            // вывод элементов по имени по умолчанию Item
            Console.WriteLine(tuple.Item2);
            tuple.Item1 += 20; //увеличение элемента кортежа на 20;
            Console.WriteLine(tuple.Item1);     
        }
        public override void Coddition_Create_Type_Method_2()
        {
            TuplesCreate(); //вывод значений кортежа по имени переменных
        }
        public override void Coddition_Create_Type_Method_3()
        {
            var tuple3 = GetValue_Tuples();
            Console.WriteLine(tuple3.Item1); //1
            Console.WriteLine(tuple3.Item2);   //3
        }
        public override void Coddition_Create_Type_Method_4()
        {
            var tuple3 = GetValue_Tuples1(("Tom", 25),10);
            Console.WriteLine(tuple3.Item1); 
            Console.WriteLine(tuple3.Item2);   //35
        }
        public static void TuplesCreate()
        {
            var (name, age) = ("Tom", 25); //переменным присваиваем кортеж
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
        public static (int, int) GetValue_Tuples()  //в качестве возвращаемного типа метода, возвращаемый кортеж типа int
        {
            int result = 1;
            int result2 = 3;
            return (result, result2); //кортеж представляет способ возвращения сразу нескольких значений
        }
        public static (string, int) GetValue_Tuples1((string, int) tuple, int x) //надо изменить чиловое значение параметра кортежа int на значение int x
        {
            var result = (name:tuple.Item1,age:tuple.Item2 + x); //можно использовать в построении методов для модулей программы
                                                                 //чтобы не переопределять методы, а сразу отправлять готовые кортежи
            return result;
        }

    }
}
