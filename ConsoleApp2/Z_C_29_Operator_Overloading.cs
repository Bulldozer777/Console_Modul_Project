using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_C_29_Operator_Overloading : Modul_Struct
    {
        public static void Z_C_29_Operator_Overloading_Info(int a)
        {
            if (a == 29)
            {
                Modul_Struct twenty_nine = new Z_C_29_Operator_Overloading();
                Modul_Struct_Start_With_DB(a, twenty_nine,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Перегрузка оператора \"+\", необходимо для сложение объектов класса",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "Перегрузка оператора \">\" и \"<\", необходимо для сложение объектов класса",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameCreate3_p: "Перегрузка оператора \"+\", другая версия",
                    OperationCreate3_p: Code_Writer_Console(a, 5),
                    NameCreate4_p: "Переопределение оператора инкремента",
                    OperationCreate4_p: Code_Writer_Console(a, 6),
                    NameExamples1_p: "Перегрузка оператора \"+\", плюс теперь работает как минус",
                    OperationExamples1_p: Code_Writer_Console(a, 4));
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {         
            Z_C_29_Counter c1 = new Z_C_29_Counter { Value = 4 };
            Z_C_29_Counter c2 = new Z_C_29_Counter { Value = 45 };
            Console.WriteLine($"\nZ_C_29_Counter c1 = {c1.Value}");
            Console.WriteLine($"Z_C_29_Counter c2 = {c2.Value}");
            Z_C_29_Counter c3 = c2 + c1;

            //некорректная запись, стала доступной
            //только после определения перегрузки в классе Z_C_29_Counter 

            Console.WriteLine($"c1 + c2 = {c3.Value}\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Z_C_29_Counter c1 = new Z_C_29_Counter { Value = 4 };
            Z_C_29_Counter c2 = new Z_C_29_Counter { Value = 45 };

            //Без переопредление операторов
            //некорректная запись , сравнение объектов

            Console.WriteLine($"\nZ_C_29_Counter c1 = {c1.Value}");
            Console.WriteLine($"Z_C_29_Counter c2 = {c2.Value}\n");
            bool c3 = c2 > c1;
            bool c4 = c2 < c1;
            Console.WriteLine($"bool c3 = c2 > c1 : {c3}");
            Console.WriteLine($"bool c3 = c2 < c1 : {c4}\n");
        }
        public override void Coddition_Examples_Type_Method_1()
        {
            Counter_1 a1 = new Counter_1() {Value = 10};
            Counter_1 a2 = new Counter_1() { Value = 30 };
            Console.WriteLine($"Counter_1 a1 = {a1.Value}");
            Console.WriteLine($"Counter_2 a2 = {a2.Value}");
            Counter_1 a3 = a1 + a2;
            Console.WriteLine($"a1 + a2 = {a3.Value}\n");
        }
        public override void Coddition_Create_Type_Method_3()
        {
            Z_C_29_Counter c1 = new Z_C_29_Counter { Value = 4 };
            Z_C_29_Counter c2 = new Z_C_29_Counter { Value = 45 };
            int y = 8;
            int z = 9;
            int c3 = c1 + y;
            int c4 = c2 + z;
            Console.WriteLine($"\ny = {y} \nZ_C_29_Counter c1 = {c1.Value }\n");
            Console.WriteLine($"z = {z} \nZ_C_29_Counter c2 = {c2.Value }\n");
            Console.WriteLine($"c1 + y = {c3}\nc2 + z = {c4}\n");
        }
        public override void Coddition_Create_Type_Method_4()
        {
            Z_C_29_Counter c1 = new Z_C_29_Counter { Value = 4 };
            Z_C_29_Counter c2 = new Z_C_29_Counter { Value = 45 };
            Console.WriteLine($"c1 = {c1.Value}");
            Console.WriteLine($"c2 = {c1.Value}");
            c1++;
            c2++;
            Console.WriteLine($"\nc1++ = {c1.Value}\nc2++ = {c2.Value}\n");
        }

    }
    class Z_C_29_Counter
    {
        public int Value { get; set; }
        //public static int operator +(int x, Z_C_29_Counter c1) //определение перегрузки
        //{
        //    return c1.Value + x; //можно переопределить оператор + и он будет работать как минус
        //}
        public static Z_C_29_Counter operator +(Z_C_29_Counter c1, Z_C_29_Counter c2) //определение перегрузки
        {
            return new Z_C_29_Counter { Value = c1.Value + c2.Value };
            //return new Z_C_29_Counter { Value = -(c1.Value - c2.Value) }; 
            //можно переопределить опертор + и он будет работать как минус
        }
        public static bool operator >(Z_C_29_Counter c1, Z_C_29_Counter c2) //определение перегрузки
        {
            if (c1.Value > c2.Value)
                return true;
            else
                return false;
        }
        public static bool operator <(Z_C_29_Counter c1, Z_C_29_Counter c2) //определение перегрузки
        {
            if (c1.Value < c2.Value)
                return true;
            else
                return false;
        }
        public static int operator +(Z_C_29_Counter c2, int y)          
        {
            return c2.Value + y; 
        }

        public static int operator +(int y, Z_C_29_Counter c2) //определение перегрузки разобраться
        {
            return c2.Value + y; //можно переопределить опертор + и он будет работать как минус
        }
        public static Z_C_29_Counter operator ++(Z_C_29_Counter c2)
        {        
            return new Z_C_29_Counter { Value = c2.Value + 1 };
        }
    }
    class Counter_1
    {
        public int Value { get; set; }
        public static Counter_1 operator +(Counter_1 c1, Counter_1 c2) //определение перегрузки
        {
            //return new Z_C_29_Counter { Value = c1.Value + c2.Value };
            return new Counter_1 { Value = (c1.Value - c2.Value) };
            //можно переопределить опертор + и он будет работать как минус
        }
    }
}
