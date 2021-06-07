using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
    class V_22_Value_Types_And_Reference_Types
    {
        public static void V_22_Value_Types_And_Reference_Types_Info(int a)
        {
            //Program.ModulRegistr(a);
            if (a == 22)
            {
                Console.WriteLine("\nТипы значений : ");
                string[] Type_Value = new string[] { "byte", "sbyte", "char", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "enum", "struct"};
               // foreach(string i in Type_Value)
              //  {
                    for (int j = 0; j < Type_Value.Length; j++)
                    {
                        Console.WriteLine($"{j+1}. {Type_Value[j]}");
                    }
                Console.WriteLine("\n");
             //   }
                Console.WriteLine("Ссылочные типы : ");
                string[] Type_Reference = new string[] { "object", "string", "class", "interface", "delegate" };
                for (int i = 0; i < Type_Reference.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Type_Reference[i]}");
                }
                string l = "class Program { static void Main(string[] args) {  Calculate(5); Console.ReadKey(); } static void Calculate(int t) {  int x = 6; int y = 7; int z = y + t; } } ";
                //l = l.Replace(" { ", "\n{\n");
                //l = l.Replace(" } ", "\n}\n");
                //l = l.Replace(";\n\n", ";\n");
              //  
               Console.WriteLine(ReplaceCompilation(l));
              
             //   Console.WriteLine(Q_17_Structures.String_Create_CompilationMethanit(l));

                string result = "\nВ чем же между ними различия? Для этого надо понять организацию памяти в .NET. Здесь память делится на два типа: стек и куча (heap). Параметры и переменные метода, которые представляют типы значений, размещают свое значение в стеке. Стек представляет собой структуру данных, которая растет снизу вверх: каждый новый добавляемый элемент помещается поверх предыдущего. Время жизни переменных таких типов ограничено их контекстом. Физически стек - это некоторая область памяти в адресном пространстве. Когда программа только запускается на выполнение, в конце блока памяти, зарезервированного для стека устанавливается указатель стека. При помещении данных в стек указатель переустанавливается таким образом, что снова указывает на новое свободное место.При вызове каждого отдельного метода в стеке будет выделяться область памяти или фрейм стека, где будут храниться значения его параметров и переменных.";
                Console.WriteLine(Q_17_Structures.Structures_Create(result));
                string k = "\nПри вызове этого метода Calculate в его фрейм в стеке будут помещаться значения t, x, y и z. Они определяются в контексте данного метода. Когда метод отработает, область памяти, которая выделялась под стек, впоследствии может быть использована другими методами. Причем если параметр или переменная метода представляет тип значений, то в стеке будет храниться непосредсвенное значение этого параметра или переменной.Например, в данном случае переменные и параметр метода Calculate представляют значимый тип - тип int, поэтому в стеке будут храниться их числовые значения. Ссылочные типы хранятся в куче или хипе, которую можно представить как неупорядоченный набор разнородных объектов. Физически это остальная часть памяти, которая доступна процессу. При создании объекта ссылочного типа в стеке помещается ссылка на адрес в куче(хипе).Когда объект ссылочного типа перестает использоваться, в дело вступает автоматический сборщик мусора: он видит, что на объект в хипе нету больше ссылок, условно удаляет этот объект и очищает память - фактически помечает, что данный сегмент памяти может быть использован для хранения других данных.";
                Console.WriteLine(Q_17_Structures.Structures_Create(k));
                Calculate_Value_Types_And_Reference_Types(5);
                State state1 = new State();
                state1.country = new Country();
                Country contry1 = new Country();
                string example = "private static void Main(string[] args) { State state1 = new State(); // Структура State State state2 = new State(); state2.x = 1; state2.y = 2; state1 = state2; state2.x = 5; // state1.x=1 по-прежнему Console.WriteLine(state1.x); // 1 Console.WriteLine(state2.x); // 5 Country country1 = new Country(); // Класс Country Country country2 = new Country(); country2.x = 1; country2.y = 4; country1 = country2;  country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2                     // указывают на один объект в хипе Console.WriteLine(country1.x); // 7 Console.WriteLine(country2.x); // 7  Console.Read();    } ";
                Console.WriteLine(ReplaceCompilation(example));
                Console.WriteLine("В классе меняется само значение переменной т к класс это ссылочный тип, а структура это тип значений и работа происходит с копией и при выводе изменений при присвоении и измении значения не будет");
            }
            Generation_Operation.EndInStart();
        }
        public static void V_22_Value_Types_And_Reference_Types_Create(int a)
        {
           
        }
        public static void Calculate_Value_Types_And_Reference_Types(int t)
        {
            int x = 6;
            int y = 7;
            int z = y + t + x;
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
