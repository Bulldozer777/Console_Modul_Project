using System;
using Microsoft.EntityFrameworkCore;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.Logging;
// System.DateTime;

namespace Training_Csharp
{
    class Program : Generation_Operation 
    {     
        public static DbContextOptions<ApplicationContext> Base_Configuration_On_File_Json()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings_Base_Training_Csharp.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
            return options;
        }

          public static void Log_File_Create(string a)
        {

        }

        static void Main(string[] args)
        {
           // U_21_Class_And_Object.Create_Directory_Modul();
            Console.WriteLine(DateTime.Now);
            InStartString();
            InStart3(int.Parse(Console.ReadLine()));
        }        
        public static void Rubbish_Console()
        {
            //int p = 0;   // счетчик цикла, сколько раз выполнился цикл
            //for (int i = 0; i < 10; i++)
            //{
            //  p++;
            //   // o++;
            //        ;
            //}
            //Console.WriteLine(p);
            //    Examples();

            //int r = Factorial_Operator(6);
            //Console.WriteLine(r);



            //Console.WriteLine(Factorial_Operator(6)); 
            //       Ternarn_Operator();
            //   Modul_Examples1();
            //   Сalculating_The_Volume.Calculating_The_Volume_Of_A_Box();
            //  Console.WriteLine();
            //   P_16_Enumeration_Enum
            // Method_Generation();
            //Fight.Provision();

            //программа для рассчета чистого объема короба

            /*  class Сalculating_The_Volume
      {
          public static void Calculating_The_Volume_Of_A_Box()
          {
              int a;
              Console.WriteLine("Введите длину (mm):");
              a = Convert.ToInt32(Console.ReadLine());
              int c;
              Console.WriteLine("Введите высоту (mm):");
              c = Convert.ToInt32(Console.ReadLine());

              int b;
              Console.WriteLine("Введите ширину (mm):");
              b = Convert.ToInt32(Console.ReadLine());

              int e;
              Console.WriteLine("Введите толщину фанеры (mm):");
              e = Convert.ToInt32(Console.ReadLine());

              int o;
              Console.WriteLine("Введите диаметр трубы (mm):");
              o = Convert.ToInt32(Console.ReadLine());

              int l;
              Console.WriteLine("Введите длину трубы (mm):");
              l = Convert.ToInt32(Console.ReadLine());
              string y;
              Console.WriteLine("Наличие двойного лба у короба (да или нет):");
              y = Convert.ToString(Console.ReadLine());
              if (y != "да" & y != "нет")
              {

                  Console.WriteLine("Наличие двойного лба у короба (да или нет):");
                  y = Convert.ToString(Console.ReadLine());
              }

              if (y == "да")
              {
                  int d = a * b * c;
                  int r = ((a - e * 2) * (b - e * 2) * (c - e * 2)) - ((b - e * 2) * (a - e * 2) * e);
                  var k = r - (3.14 * o * o * 0.25 * l);
                  var u = Math.Floor(d * 0.0001) * 0.01; // = 25.01
                  var p = Math.Floor(r * 0.0001) * 0.01; // = 25.01
                  var m = Math.Floor(k * 0.0001) * 0.01; // = 25.01
                  var s = k - 10000000;
                  var z = Math.Floor(s * 0.0001) * 0.01; // = 25.01
                  Console.WriteLine("Объем равен " + u);
                  Console.WriteLine("Объем c учетом толщины фанеры равен " + p);
                  Console.WriteLine("Объем c учетом толщины фанеры равен и вытеснетия объема трубы " + m);
                  Console.WriteLine("Чистый объем короба с динамиком внутри, динамик Т15, 10 литров " + z);
              }
              else if (y == "нет")
              {
                  int d = a * b * c;
                  int r = ((a - e * 2) * (b - e * 2) * (c - e * 2));
                  var k = r - (3.14 * o * o * 0.25 * l);
                  var u = Math.Floor(d * 0.0001) * 0.01; // = 25.01
                  var p = Math.Floor(r * 0.0001) * 0.01; // = 25.01
                  var m = Math.Floor(k * 0.0001) * 0.01; // = 25.01
                  var s = k - 10000000;
                  var z = Math.Floor(s * 0.0001) * 0.01; // = 25.01
                  Console.WriteLine("Объем равен " + u);
                  Console.WriteLine("Объем c учетом толщины фанеры равен " + p);
                  Console.WriteLine("Объем c учетом толщины фанеры равен и вытеснетия объема трубы " + m);
                  Console.WriteLine("Чистый объем короба с динамиком внутри, динамик Т15, 10 литров " + z);
              }
              else
              {
                  Console.WriteLine("Введите верный ответ");
              }

          }


          class Calculator
          {
              public static void Add(int x, int y)
              {
                  int z = x + y;
                  Console.WriteLine($"Сумма {x} и {y} равна {z} ");
              }
          }
    */
            //программа для постоения структуры основной программы
            // примеры 

            //  // if (p == a) ;
            //  int Registr = int.Parse(Console.ReadLine());
            //  Modul_Registr_Operation Registr_Enum;
            //  Registr_Enum = Modul_Registr_Operation.FirstProgramCreate;
            ////  (int)Registr_Enum;
            ////  Registr_Enum = Registr;
            //  Console.WriteLine($"Вы ввели Registr {Registr}");
            //  Console.WriteLine($"Вы ввели Registr_Enum {Registr_Enum}");
            //switch(op)
            //     {
            //     case Modul_Registr_Operation.FirstProgramCreate:
            //         A_1_FirstProgram.FirstProgramCreate(Registr);
            //         break;
            //     }
            //if (Registr == (int)Registr_Enum)
            //  {
            //      A_1_FirstProgram.FirstProgramCreate(Registr);
            //      B_2_CompilationInComandString2.CompilationInComandStringInfo(Registr);
            //      C_3_VariablesEndTypeCsharp.TypeScharpExperience(Registr);
            //      Q_17_Structures.Structures_Info(Registr);
            //  }


            //программа для постоения структуры основной программы, попытки через enum
            /*   public static void Method_Generation(Modul_Registr_Operation op, int a)
               {
                   Console.WriteLine("Введите номер модуля необходимый для вывода в консоль, ведите 99 для информации по модулям с#");

                   switch (op)
                   {
                       case Modul_Registr_Operation.FirstProgramCreate:
                           A_1_First_Program.FirstProgramCreate(a);
                           break;
                       case Modul_Registr_Operation.CompilationInComandStringInfo:
                           B_2_Compilation_In_Comand_String.CompilationInComandStringInfo(a);
                           break;
                       case Modul_Registr_Operation.TypeScharpExperience:
                           C_3_Variables_End_Type_Csharp.TypeScharpExperience(a);
                           break;


                   }
               }
            */
           
        }
        public static void Ternarn_Operator()
        {
            int x = 3; //условные выражения
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string selection = Console.ReadLine();
            int z = selection == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
        }
        public static int Factorial_Operator(int x)
        {
            int result = 1; //условные выражения
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }
        public static void Examples()
        {
            int r = Factorial_Operator(6);
            Console.WriteLine(r);
        }
        enum Modul_Registr_Operation
        {
            FirstProgramCreate,
            CompilationInComandStringInfo,
            TypeScharpExperience
        }
    }

    }

    



 

