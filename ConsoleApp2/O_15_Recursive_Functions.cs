using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;


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
                    "\nВведите 3 для получения данных из базы, исходя из совпадения значения столбца NameInfo1");
                int Key = int.Parse(Console.ReadLine());                          
                if (Key == 1)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        Modul_Struct_Base Modul_15 = new Modul_Struct_Base
                        {
                            NameInfo1 = identification_name,
                            OperationInfo1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1)),
                            NameCreate1 = "Метод, который находит факториал числа",
                            NameCreate2 = "Метод, который находит число Фиббоначи по порядковому номеру",
                            OperationCreate1 = Code_Writer_Console(a, 2),
                            OperationCreate2 = Code_Writer_Console(a, 3),
                        };
                        Add_Modul_Struct_Bases(Modul_15);
                        //identification = Modul_15.Id;
                    }
                }
                if (Key == 2)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        var Modul_15_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Данные после добавления:");
                        foreach (Modul_Struct_Base u in Modul_15_1)
                        {
                            if (u.Id == identification)
                            {
                                Modul_Struct Fifteen = new O_15_Recursive_Functions();
                                Fifteen.operation_Info_Method_1 = u.OperationInfo1;
                                Fifteen.operation_Create_Method_1 = u.OperationCreate1;
                                Fifteen.operation_Create_Method_2 = u.OperationCreate2;
                                Fifteen.name_Create_Method_1 = u.NameCreate1;
                                Fifteen.name_Create_Method_2 = u.NameCreate2;
                                Q_17_Structures.Structures_Create(Fifteen.operation_Info_Method_1);
                                Fifteen.Method_Modul_Start_1();
                            }                       
                        }
                    }
                }
                if (Key == 3)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        var Modul_15_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Данные после добавления:");
                        foreach (Modul_Struct_Base u in Modul_15_1)
                        {
                            if (u.NameInfo1 == identification_name)
                            {
                                Modul_Struct Fifteen = new O_15_Recursive_Functions();
                                Fifteen.operation_Info_Method_1 = u.OperationInfo1;
                                Fifteen.operation_Create_Method_1 = u.OperationCreate1;
                                Fifteen.operation_Create_Method_2 = u.OperationCreate2;
                                Fifteen.name_Create_Method_1 = u.NameCreate1;
                                Fifteen.name_Create_Method_2 = u.NameCreate2;
                                Q_17_Structures.Structures_Create(Fifteen.operation_Info_Method_1);
                                Fifteen.Method_Modul_Start_1();
                            }
                        }
                    }
                }
            }          
            Generation_Operation.EndInStart();
        }
        public static void Add_Modul_Struct_Bases(Modul_Struct_Base Name_Object_Base)
        {
            using (ApplicationContext db = new ApplicationContext())
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
            Console.WriteLine($"Факториал числа {k}, равен: {Factorial(k)}");            
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
