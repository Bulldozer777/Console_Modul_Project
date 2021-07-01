using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Modul_Operation
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Modul_Operation
    {

    }
    class Fight
    {
       
          //case 1:
          //                      m = "Первая программа";
          //                      break;
          //                  case 2:
          //                      m = "Компиляция в командной строке";
          //                      break;
          //                  case 3:
          //                      m = "Переменные и типы данных";
          //                      break;
          //                  case 4:
          //                      m = "Арифметические операции";
          //                      break;
          //                  case 5:
          //                      m = "Поразрядные операции";
          //                      break;
          //                  case 6:
          //                      m = "Преобразования базовых типов данных";
          //                      break;
          //                  case 7:
          //                      m = "Условные выражения";
          //                      break;
          //                  case 8:
          //                      m = "Условные конструкции";
          //                      break;
          //                  case 9:
          //                      m = "Циклы";
          //                      break;
          //                  case 10:
          //                      m = "Массивы";
          //                      break;
          //                  case 11:
          //                      m = "Методы";
          //                      break;
          //                  case 12:
          //                      m = "Параметры метода";
          //                      break;
          //                  case 13:
          //                      m = "Ключевое слово params и массив параметров";
          //                      break;
          //                  case 14:
          //                      m = "Область видимости переменных";
          //                      break;
          //                  case 15:
          //                      m = "Рекурсивные функции";
          //                      break;
          //                  case 16:
          //                      m = "Перечисления enum";
          //                      break;
          //                  case 17:
          //                      m = "Структуры";
          //                      break;
          //                  case 18:
          //                      m = "Кортежи";
          //                      break;
          //                  case 19:
          //                      m = "Обработка исключений";
          //                      break;
          //                  case 20:
          //                      m = "Переменные-ссылки и получение ссылки";
          //                      break;
          //                  case 21:
          //                      m = "Классы и объекты";
          //                      break;
          //                  case 22:
          //                      m = "Типы значений и ссылочные типы";
          //                      break;
          //                  case 23:
          //                      m = "Объекты классов как параметры методов";
          //                      break;
          //                  case 24:
          //                      m = "Модификаторы доступа";
          //                      break;
          //                  case 25:
          //                      m = "Константы и поля для чтения";
          //                      break;
          //                  case 26:
          //                      m = "Свойства";
          //                      break;
          //                  case 27:
          //                      m = "Перегрузка методов";
          //                      break;
          //                  case 28:
          //                      m = "Модификатор static. Статические классы и члены классов";
          //                      break;
          //                  case 29:
          //                      m = "Перегрузка операторов";
          //                      break;
        public int i;
        List<int> Modul = new List<int>
        {
          //  GO();
        };
        public static void Provision()
        {
            List<string> operation = new List<string>{
            "Первая программа",
            "Компиляция в командной строке",
            "Переменные и типы данных",
            "Арифметические операции",
            "Поразрядные операции",
            "Преобразования базовых типов данных",
            "Условные выражения",
            "Условные конструкции"};
      //   Console.WriteLine("Введите номер:");
            //int o = int.Parse(Console.ReadLine());
            //for (int i = 0; i < operation.Capacity; i++)
            //{
            //    operation[i] = o;
            //    if (+1 == o)
            //    {
                   BaseModul(GO());
            //    }
            //}
           
        }
        public static int GO()
        {
            Console.WriteLine("Введите номер:");
            int o = int.Parse(Console.ReadLine());
            return o;
        }
        public static void Lean()
        {
            GO();

        }

        public static void BaseModul(int a)
        {
           
                A_1_First_Program.FirstProgramCreate(a);
           
                //B_2_CompilationInComandString2.CompilationInComandStringInfo(a);
          
                C_3_Variables_End_Type_Csharp.TypeScharpExperience(a);
            
            //    _4ArithmeticOperations.ArithmeticOperationsInfo(a);
                // VariablesEndTypeCsharp3.TypeScharpExperience(a);
           
                //   VariablesEndTypeCsharp3.TypeScharpExperience(a);
            
             //   CreateBaseTypeData6.TypeCreate(a);
           
                L_12_Method_Parameters.Method_Parameters(a);
           
           //     _13Keyword_Params.Keyword_Params_Info(a);
           
            //    _14Scope_Of_Variables.Scope_Of_Variables_Info(a);
           
           //     _15Recursive_Functions.Recursive_Functions_Info(a);
           
                P_16_Enumeration_Enum.Enumeration_Enum_Info(a);
            
                Q_17_Structures.Structures_Info(a);
            
                R_18_Tuples.TuplesInfo(a);
            
                S_19_Exceptions.ExceptionsInfo(a);
           
                T_20_Variables_Links_And_Getting_Links.Variables_Info(a);
            
                U_21_Class_And_Object.Class_And_Object_Info(a);
          
                V_22_Value_Types_And_Reference_Types.V_22_Value_Types_And_Reference_Types_Info(a);
            
                W_23_Class_Objects_As_Method_Parameters.W_23_Class_Objects_As_Method_Parameters_Info(a);
           
                X_24_Access_Modifiers.X_24_Access_Modifiers_Info(a);
          
                Y_25_Constants_And_Read_Fields.Y_25_Constants_And_Read_Fields_Info(a);
           
                Z_26_Property.Z_26_Property_Info(a);
      
        }

    }
}
