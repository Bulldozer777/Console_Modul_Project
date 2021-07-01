﻿using System;
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
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));


                Z_C_29_Counter c1 = new Z_C_29_Counter {Value = 4 };
                Z_C_29_Counter c2 = new Z_C_29_Counter { Value = 45 };
                bool result = c1 > c2; //некорректная запись 
                Z_C_29_Counter c3 = c2 + c1; //некорректная запись, стала доступной только после определения перегрузки в классе Z_C_29_Counter 
                Console.WriteLine(result);
                Console.WriteLine(c3.Value);
               // int x = c2 + 20;
             
              int y = 20 + c2; // разобраться с этим случаем , возможна ошибка
                Console.WriteLine(y);
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_C_29_Operator_Overloading_Create()
        {

        }
    }
    class Z_C_29_Counter
    {
        public int Value { get; set; }
        public static int operator +(int x, Z_C_29_Counter c1) //определение перегрузки
        {
            return c1.Value + x; //можно переопределить опертор + и он будет работать как минус
        }
        public static Z_C_29_Counter operator +(Z_C_29_Counter c1, Z_C_29_Counter c2) //определение перегрузки
        {
            return new Z_C_29_Counter { Value = -(c1.Value - c2.Value) }; //можно переопределить опертор + и он будет работать как минус
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
        //public static int operator +( int y, Z_C_29_Counter c2) //определение перегрузки, порядок не играет роли/, раньше порядок играл роль согласно курсам метанит
        //{
        //    return c2.Value + y; //можно переопределить опертор + и он будет работать как минус
        //}
        //public static int operator +(int y, Z_C_29_Counter c2) //определение перегрузки
        //{
        //    return c2.Value + y; //можно переопределить опертор + и он будет работать как минус
        //}
    }
}
