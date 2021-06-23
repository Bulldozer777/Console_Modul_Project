using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    struct State
    {
        public int x;
        public int y;
        public Country country;
    }
    class Country
    {
        public int x;
        public int y;
    }
    class V_22_Value_Types_And_Reference_Types : Modul_Struct
    {
        public static void V_22_Value_Types_And_Reference_Types_Info(int a)
        {
            //Program.ModulRegistr(a);
            if (a == 22)
            {
                Modul_Struct twenty_two = new U_21_Class_And_Object();
                Modul_Struct_Start_With_DB(a, twenty_two,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1)),
                    NameCreate1_p: "Типы значений, метод Calculate",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "Ссылочные типы ",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameCreate3_p: "Составные типы",
                    OperationCreate3_p: Code_Writer_Console(a, 4),
                    NameCreate4_p: "Копирование значений, для структур и классов",
                    OperationCreate4_p: Code_Writer_Console(a, 5),
                    NameCreate5_p: "Ссылочные типы внутри типов значений",
                    OperationCreate5_p: Code_Writer_Console(a, 6),
                    NameExamples1_p: "",
                    OperationExamples1_p: Code_Writer_Console(a, 6)
                    );                   
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_2()
        {
            string[] Type_Value = new string[] { "byte", "sbyte", "char", "short", "ushort", 
                "int", "uint", "long", "ulong", "float", "double", "enum", "struct" };
            for (int j = 0; j < Type_Value.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {Type_Value[j]}");
            }
            Console.WriteLine("\n");
            Calculate_Value_Types_And_Reference_Types_1(5);
        }
        public override void Coddition_Create_Type_Method_1()
        {
            string[] Type_Reference = new string[] { "object", "string", "class", "interface", "delegate" };
            for (int i = 0; i < Type_Reference.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Type_Reference[i]}");
            }
            Console.WriteLine("\n");
            Calculate_Value_Types_And_Reference_Types(5);
        }
        public override void Coddition_Create_Type_Method_3()
        {
            State state1 = new State(); 
            state1.country = new Country();
            Country contry1 = new Country();
            Console.WriteLine(state1);
            Console.WriteLine(state1.country);
            Console.WriteLine(contry1);
        }
        public override void Coddition_Create_Type_Method_4()
        {          
                Console.WriteLine($"Чтобы запустить \"Копирование значений, для структур\" нажмите 1 ");           
                Console.WriteLine($"Чтобы запустить \"Копирование значений, для классов\" нажмите 2 ");
            int key = int.Parse(Console.ReadLine());          
            if (key == 1)
            {
                Console.WriteLine("Копирование значений, для структур\n");
                State state1 = new State(); // Структура State
                State state2 = new State();
                state2.x = 1;
                state2.y = 2;
                state1 = state2;
                state2.x = 5; // state1.x=1 по-прежнему
                Console.WriteLine(state1.x); // 1
                Console.WriteLine(state2.x); // 5
                Console.WriteLine("\n");
            }
            if (key == 2)
            {
                Console.WriteLine("Копирование значений, для классов\n");
                Country country1 = new Country(); // Класс Country
                Country country2 = new Country();
                country2.x = 1;
                country2.y = 4;
                country1 = country2;
                country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2 
                                // указывают на один объект в хипе
                Console.WriteLine(country1.x); // 7
                Console.WriteLine(country2.x); // 7
                Console.WriteLine("\n");
            }
        }
        public override void Coddition_Create_Type_Method_5()
        {
            Console.WriteLine("\n");
            State state1 = new State();
            State state2 = new State();

            state2.country = new Country();
            state2.country.x = 5;
            state1 = state2;
            state2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
                                  // указывают на один объект в хипе
            Console.WriteLine(state1.country.x); // 8
            Console.WriteLine(state2.country.x); // 8
            Console.WriteLine("\n");
        }
        public static void Calculate_Value_Types_And_Reference_Types(int t)
        {
            int x = 6;
            int y = 7;
            int z = y  + t;
        }
        public static void Calculate_Value_Types_And_Reference_Types_1(int t)
        {
           object x = 6;
            int y = 7;
            int z = y + t;
        }
        public static string ReplaceCompilation(string l)
        {
            string u = "";
            l = l.Replace(" { ", "\n{\n");
            l = l.Replace(" } ", "\n}\n");
            l = l.Replace(";", ";\n");
            l = l.Replace(";\n\n", ";\n");
            l = l.Replace("\\", ";\n \\");
            u = "\n" + l;
            return u;
        }
    }
}
