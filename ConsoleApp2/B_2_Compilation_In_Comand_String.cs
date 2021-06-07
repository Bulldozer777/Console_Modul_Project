using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  
    class B_2_Compilation_In_Comand_String
    {

        public static void CompilationInComandStringInfo(int i)
        {

            if (i == 2)
            {
                Console.WriteLine("Создаем текстовый документ на ПК через блокнот");
                Console.WriteLine("Пишем код на C# и сохраняем его на локальном диске в формате файла .cs, пример \"Program.cs\"");
                Console.WriteLine("Открываем командную строку и указываем путь к файлу Visual Studio имя файл \"csc.exe\"");
                string a = "C:\\Program Files(x86)\\Microsoft Visual Studio\\2019\\Community\\MSBuild\\Current\\Bin\\Roslyn\\csc.exe";
                Console.WriteLine($"В моем случае путь к файлу\n \"{a}\"");
                Console.WriteLine("Используем команду \"cd\" для перехода к разделу с нужным файлом");
                Console.WriteLine("Далее пишем имя созданного в блокноте файла , пример \"Program.cs\"");
                Console.WriteLine("Программа скомпилируется в консоли и создаст .exe файл, в папке расположения файла \"Program.cs\"");
                Console.WriteLine("Программа будет выполнять действия согласно инструкциям на C#, описанным в файле \"Program.cs\"");
                Console.WriteLine("\nПрограмма выводит текущую дату и время:");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("\nusing System;\n namespace helloapp\n {\n  class Program\n  {\n   static void Main(string[] args)\n   {  \n     Console.WriteLine(DateTime.Now);\n   }\n  }\n }");
                Generation_Operation.EndInStart();
            }
        }
        //public static void CompilationInComandStringInfo1()
        //{
        //    int u = 10;
        //    int z = 12;
        //    int p = 17;
        //    //if (u + z > p && z + p > u) // при двух true срабатывает 
        //    //{
        //    //    Console.WriteLine("Условие выполнено");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Условие не выполнено");
        //    //}
        //    //if (u + z > p | z + p < u) //  // при одном tRue срабатывает
        //    //{
        //    //    Console.WriteLine("Условие выполнено");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Условие не выполнено");
        //    //}
        //    if (u + z < p || z + p < u) //  // при одном tRue срабатывает , тоже самое что и 1 палка
        //    {
        //        Console.WriteLine("Условие выполнено");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Условие не выполнено");
        //    }
        //}
    }
}
