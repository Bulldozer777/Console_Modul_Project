using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Training_Csharp;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base
{
    class Modul_Base
    {
        public static void Modul_Base_Method()
        {
            //var builder = new ConfigurationBuilder();
            //// установка пути к текущему каталогу
            //builder.SetBasePath(Directory.GetCurrentDirectory());
            //// получаем конфигурацию из файла appsettings.json
            //builder.AddJsonFile("appsettings_Base_Training_Csharp.json");
            //// создаем конфигурацию
            //var config = builder.Build();
            //// получаем строку подключения
            //string connectionString = config.GetConnectionString("DefaultConnection");

            //var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            //var options = optionsBuilder
            //    .UseSqlServer(connectionString)
            //    .Options; ;
            using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
            {
                Modul_Struct_Base Modul_1 = new Modul_Struct_Base
                {
                    NameCreate1 = Q_17_Structures.String_Create_CompilationMethanit(Modul_Struct.Code_Writer_Console(1, 3))
                };
                int i = 2;
                //    Modul_Struct_Base Modul_2 = new Modul_Struct_Base
                //     {                   
                //    name_Create_Method_1_Base = "Логическое умножение",
                //    name_Create_Method_2_Base = "Логическое сложение",
                //    name_Create_Method_3_Base = "Операция исключающего \"или\" или XOR",
                //    name_Create_Method_4_Base = "Логическое отрицание или инверсия",
                //    name_Create_Method_5_Base = "Операции сдвига",
                //    operation_Create_Method_1_Base = Modul_Struct.Code_Writer_Console(i, 1),
                //    operation_Create_Method_2_Base = Modul_Struct.Code_Writer_Console(i, 2),
                //    operation_Create_Method_3_Base = Modul_Struct.Code_Writer_Console(i, 3),
                //    operation_Create_Method_4_Base = Modul_Struct.Code_Writer_Console(i, 4),
                //    operation_Create_Method_5_Base = Modul_Struct.Code_Writer_Console(i, 5),
                //    create_Create_Method_1_Base = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Logic_Multiplication(),
                //    create_Create_Method_2_Base = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_Addition(),
                //    create_Create_Method_3_Base = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_OR(),
                //    create_Create_Method_4_Base = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_Inversion(),
                //    create_Create_Method_5_Base = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_The_Shift(),
                //};
                db.Modul_Struct_Bases.Add(Modul_1);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
                var Modul_Struct_Bases = db.Modul_Struct_Bases.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Modul_Struct_Base p in Modul_Struct_Bases)
                {
                    FileStream file1 = new FileStream("C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2\\Modul_Csharp_Base.txt", FileMode.Create); //создаем файловый поток
                    StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
                    writer.Write($"{p.Id} - {p.NameCreate1} ");
                    //$"+ {p.name_Create_Method_2_Base} + " +
                    //$"{p.name_Create_Method_3_Base} + {p.name_Create_Method_4_Base} + {p.name_Create_Method_5_Base}" +
                    //$"{p.operation_Create_Method_1_Base} + {p.operation_Create_Method_2_Base} + {p.operation_Create_Method_3_Base}" +
                    //$"{p.operation_Create_Method_4_Base} + {p.operation_Create_Method_5_Base} + {p.create_Create_Method_1_Base}" +
                    //$"{p.create_Create_Method_2_Base} + {p.create_Create_Method_3_Base} + {p.create_Create_Method_4_Base}" +
                    //$"{p.create_Create_Method_5_Base}" ); //записываем в файл
                    writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
                }
            }
        }
        //public static void Modul_Base_Method_1()
        //{
        //    using (ApplicationContext db = new ApplicationContext(options))
        //    {
        //        int i = 5;
        //        Modul_Struct_Base Modul_2 = new Modul_Struct_Base
        //        {
        //            //    NameCreate1 = "Логическое умножение",
        //            //    NameCreate2 = "Логическое сложение",
        //            //    NameCreate3 = "Операция исключающего \"или\" или XOR",
        //            //    NameCreate4 = "Логическое отрицание или инверсия",
        //            //    NameCreate5 = "Операции сдвига",
        //            OperationCreate1 = Modul_Struct.Code_Writer_Console(i, 1),
        //            OperationCreate2 = Modul_Struct.Code_Writer_Console(i, 2),
        //            OperationCreate3 = Modul_Struct.Code_Writer_Console(i, 3),
        //            OperationCreate4 = Modul_Struct.Code_Writer_Console(i, 4),
        //            OperationCreate5 = Modul_Struct.Code_Writer_Console(i, 5),
        //            CreateCreate1 = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Logic_Multiplication(),
        //            CreateCreate2 = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_Addition(),
        //            CreateCreate3 = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_OR(),
        //            CreateCreate4 = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_Inversion(),
        //            CreateCreate5 = E_5_Bitwise_Operations.E_5_Bitwise_Operations_Create_Logic_The_Shift(),
        //        };
        //        db.Modul_Struct_Bases.Add(Modul_2);
        //        db.SaveChanges();                
        //        Console.WriteLine("Объекты успешно сохранены");
        //    }

        //}
        //public static void Modul_Base_Method_2()
        //{
        //    using (ApplicationContext db = new ApplicationContext(Options))
        //    {
        //        int i = 15;
        //        Modul_Struct_Base Modul_15 = new Modul_Struct_Base
        //        {
        //            OperationCreate1 = Modul_Struct.Code_Writer_Console(i, 1)
        //        };
        //        db.Modul_Struct_Bases.Add(Modul_15);
        //        db.SaveChanges();
        //        Console.WriteLine("Объекты успешно сохранены");
        //        Modul_Struct Fifteen = new O_15_Recursive_Functions();
        //        Modul_15.OperationCreate1 = Fifteen.operation_Info_Method_1;
        //    }
        //}
    }
}