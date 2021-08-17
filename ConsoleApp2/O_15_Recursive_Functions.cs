using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;
using Training_Csharp.Log_Training_Csharp_Base;

namespace Training_Csharp
{
    class O_15_Recursive_Functions : Modul_Struct
    {
        public static void Recursive_Functions_Info(int a)
        {
            if (a == 15)
            {
                int identification = 17;
                string identification_name = Generation_Operation.BaseModul(a);
                Console.WriteLine(" Введите 1 для заполнения базы," +
                    "\n Введите 2 для получения данных из базы, исходя из совпадения значения столбца Id" +
                    "\n Введите 3 для получения данных из базы, исходя из совпадения значения столбца NameInfo1"+
                    "\n Введите 4 для удаления данных из базы, исходя из совпадения значения столбца NameInfo1");
                int Key = int.Parse(Console.ReadLine());                          
                if (Key == 1)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        //db.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
                        //Выше логгирование устанавливалось локально
                        //- непосредственно при создании и использовании объкта контекста данных.
                        //Однако мы можем определить глобальную настройку логгирования непосредственно в контексте
                        //(Определено в классе ApplicationContext)
                        Modul_Struct_Base Modul_15 = new Modul_Struct_Base
                        {
                            NameInfo1 = identification_name,
                            OperationInfo1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1)),
                            NameCreate1 = "Метод, который находит факториал числа",
                            NameCreate2 = "Метод, который находит число Фиббоначи по порядковому номеру",
                            OperationCreate1 = Code_Writer_Console(a, 2),
                            OperationCreate2 = Code_Writer_Console(a, 3),
                        };
                        Add_Modul_Struct_Bases(Modul_15, Program.Base_Configuration_On_File_Json());
                        //identification = Modul_15.Id;
                    }
                }
                if (Key == 2)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        var Modul_15_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Данные после добавления:");
                        foreach (Modul_Struct_Base u in Modul_15_1)
                        {
                            if (u.Id == identification)
                            {
                                Modul_Struct Fifteen = new O_15_Recursive_Functions();
                                Fifteen.Operation_Info_Method_1 = u.OperationInfo1;
                                Fifteen.Operation_Create_Method_1 = u.OperationCreate1;
                                Fifteen.Operation_Create_Method_2 = u.OperationCreate2;
                                Fifteen.Name_Create_Method_1 = u.NameCreate1;
                                Fifteen.Name_Create_Method_2 = u.NameCreate2;
                                Structures_Create(Fifteen.Operation_Info_Method_1);
                                Fifteen.Method_Modul_Start_1(a);
                            }                       
                        }
                    }
                }
                if (Key == 3)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        var Modul_15_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Данные после добавления:");
                        foreach (Modul_Struct_Base u in Modul_15_1)
                        {
                            if (u.NameInfo1 == identification_name)
                            {
                                Modul_Struct Fifteen = new O_15_Recursive_Functions();
                                Fifteen.Operation_Info_Method_1 = u.OperationInfo1;
                                Fifteen.Operation_Create_Method_1 = u.OperationCreate1;
                                Fifteen.Operation_Create_Method_2 = u.OperationCreate2;
                                Fifteen.Name_Create_Method_1 = u.NameCreate1;
                                Fifteen.Name_Create_Method_2 = u.NameCreate2;
                                Structures_Create(Fifteen.Operation_Info_Method_1);
                                Fifteen.Method_Modul_Start_1(a);
                            }
                        }
                    }
                }
                if(Key == 4)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        int count = 0;
                        var Modul_16_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Получение данных из базы:");
                        foreach (Modul_Struct_Base u in Modul_16_1)
                        {
                            count++;
                            Console.Clear();
                            Console.WriteLine($"Выполняется {count} поиск строк с полем NameInfo1 = {Generation_Operation.BaseModul(a)}");
                            if (u.NameInfo1 == Generation_Operation.BaseModul(a))
                            {
                                Console.WriteLine($"Проиходит удаление всех строк с NameInfo1 = {Generation_Operation.BaseModul(a)}");
                                db.Modul_Struct_Bases.Remove(u);
                                Console.WriteLine("Выполняется сохранение изменений в базу");
                                db.SaveChanges();
                            }
                        }
                        Console.WriteLine("Удаление записи, по имени темы выполнено");
                    }
                }
            }          
            Generation_Operation.EndInStart();
        }
        public static void Add_Modul_Struct_Bases(Modul_Struct_Base Name_Object_Base, DbContextOptions<ApplicationContext> o)
        {
            using (ApplicationContext db = new ApplicationContext(o))
            {
                db.Modul_Struct_Bases.Add(Name_Object_Base);         
                db.SaveChanges();
            }
        }
        public override void Coddition_Create_Type_Method_2()
        {
            int k;
            Console.WriteLine("Введите порядковый номер числа Фиббоначи");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nЧисло Фиббоначи по порядковому номеру - {k}, равно: {Fibbonacci(k)}\n");           
        }
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int z = n * Factorial(n - 1);    //Factorial(5) = 5 * Factorial(4) = 5 * 4 * Factorial(3).;.. = 5 * 4 * 3 * 2 * 1 * 1 ;
                return z;
            }
        }
        public override void Coddition_Create_Type_Method_1()
        {
            int k;
            Console.WriteLine("Введите число, факториал которого вы хотите найти");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nФакториал числа {k}, равен: {Factorial(k)}\n");            
        }      
        public static int Fibbonacci(int n)
        {
            if (n == 0 )
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }
            else
            {
                int z = Fibbonacci(n - 1)+ Fibbonacci(n - 2);   
                return z;
            }
        }       
    }
}
