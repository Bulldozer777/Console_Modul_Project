using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_D_30_Overloading_Type_Conversion_Operations : Modul_Struct
    {
        public static void Z_D_30_Overloading_Type_Conversion_Operations_Info(int a)
        {
            if (a == 30)
            {
                Modul_Struct thirty = new Z_D_30_Overloading_Type_Conversion_Operations();
                Modul_Struct_Start_With_DB(a, thirty,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Преобразование базовых типов, примеры",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "Преобразование типов класса Counter к примитивным типам",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameCreate3_p: "Преобразование типов класса Counter к типам другого класса",
                    OperationCreate3_p: Code_Writer_Console(a, 4));
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            int x = 50;
            byte y = (byte)x; //явное преобразование
            int z = y; //неявное преобразование

            Console.WriteLine($"y = {y} - неявное преобразование");
            Console.WriteLine($"z = {z} - неявное преобразование\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Counter counter1 = new Counter { Seconds = 115 };
            int x = counter1.Seconds;

            //int x = counter1; некорректно
            //Counter counter2 = x;  некорректно

            Counter counter2 = x;

            //после неявного преобразования логика которого описана в классе Counter

             x = (int)counter2;

            //после явного преобразования логика которого описана в классе Counter

            Console.WriteLine($"Counter counter2 = x; counter2.Seconds = {counter2.Seconds}");

            Console.WriteLine($"int x = (int)counter2; x = {x}\n");
        }
        public override void Coddition_Create_Type_Method_3()
        {
            Counter counter1 = new Counter { Seconds = 115 };

            //Timer timer1 = counter1; некорректно
            //Counter counter2 = timer1; некорректно 
            //до операции преобразования типов

            Timer timer1 = counter1; 
            Counter counter2 = (Counter)timer1; 

            Console.WriteLine($"Timer timer1 = counter1;\ntimer1 = " +
                $"{timer1.Hours} : {timer1.Minutes} : {timer1.Seconds} \n");
            Console.WriteLine($"Counter counter2 = (Counter)timer1;\n" +
                $"counter2 = {counter2.Seconds}\n");
        }
        class Counter
        { 
            public int Seconds { get; set; }
            public static implicit operator Counter (int x)

            //слово explicit (если преобразование явное,
            //то есть нужна операция приведения типов)
            //или implicit (если преобразование неявное)

            {
                return new Counter { Seconds = x };
            }
            public static explicit operator int(Counter counter)

            //слово explicit (если преобразование явное,
            //то есть нужна операция приведения типов)
            //или implicit (если преобразование неявное)

            {
                return counter.Seconds;
            }
            //public static explicit operator int(Counter counter)
            //{
            //    return counter.Seconds;
            //}
            public static explicit operator Counter(Timer timer)
            {
                int h = timer.Hours * 3600;
                int m = timer.Minutes * 60;
                return new Counter { Seconds = h + m + timer.Seconds };
            }
            public static implicit operator Timer(Counter counter)  

                //неявное
                //Timer(Counter counter) преобразование от Counter к Timer

            {
                int h = counter.Seconds / 3600;
                int m = (counter.Seconds - h * 3600)/60;
                int s = counter.Seconds - h * 3600 - m * 60;
                return new Timer { Hours = h, Minutes = m, Seconds = s };
            }
        }
        class Timer
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
        }
    }
}
