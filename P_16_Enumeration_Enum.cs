using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;
using Microsoft.Data.SqlClient;

namespace Training_Csharp
{
    enum Days // int имеет тип по умолчанию 
    {
        Monday = 1,   //1
        Tuesday,    //2
        Wednesday,    //3
        Thursday,     //4
        Friday,
        Saturday,
        Sunday
    }
    class P_16_Enumeration_Enum : Modul_Struct
    {
        enum Days1 // int имеет тип по умолчанию 
        {
            Monday ,   //0
            Tuesday,    //1
            Wednesday,    //2
            Thursday,     //3
            Friday,
            Saturday,
            Sunday
        }
        enum Days2 // int имеет тип по умолчанию 
        {
            Monday,   //0
            Tuesday,    //1
            Wednesday,    //2
            Thursday,     //3
            Friday = 17,
            Saturday,   //18
            Sunday
        }
        enum Operation // int имеет тип по умолчанию 
        {
            Add,   //0
            Substract,    //1
            Multiply,    //2
            Divide,     //3
        }       
       static void Enumeration_Enum_Create(double x, double y, Operation op)  // public модификатор нельзя поставить
        {
            double result = 0.0;
            switch(op)
            {
                case Operation.Add:
                  result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine(result);
        }
        public static void Enumeration_Enum_Info(int a)
        {
            if (a == 16)
            {
                string identification_name = Generation_Operation.BaseModul(a);
                Console.WriteLine(" Введите 1 для заполнения базы," +
                    "\n Введите 2 для получения данных из базы, исходя из совпадения значения столбца NameInfo1" +
                    "\n Введите 3 для удаления данных из базы, исходя из совпадения значения столбца NameInfo1" +
                    "\n Введите 4 для редактирование данных из базы, исходя из совпадения значения столбца NameInfo1");
                int Key = int.Parse(Console.ReadLine());
                if (Key == 1)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        Modul_Struct_Base Modul_16 = new Modul_Struct_Base
                        {
                            NameInfo1 = identification_name,
                            OperationInfo1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1)) + Code_Writer_Console(a, 4),
                            NameCreate1 = "Перечисления для нахождения дня недели",
                            NameCreate2 = "Перечисления для хранения математических операций",
                            OperationCreate1 = Code_Writer_Console(a, 2),
                            OperationCreate2 = Code_Writer_Console(a, 3),
                        };
                        O_15_Recursive_Functions.Add_Modul_Struct_Bases(Modul_16, Program.Base_Configuration_On_File_Json());
                        Console.WriteLine("Добавление данных в базу выполненено успешно");
                    }
                }
                if (Key == 2)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        var Modul_16_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Получение данных из базы:");
                        foreach (Modul_Struct_Base u in Modul_16_1)
                        {
                            if (u.NameInfo1 == identification_name)
                            {
                                Modul_Struct Sixteen = new P_16_Enumeration_Enum();
                                Sixteen.Operation_Info_Method_1 = u.OperationInfo1;
                                Sixteen.Operation_Create_Method_1 = u.OperationCreate1;
                                Sixteen.Operation_Create_Method_2 = u.OperationCreate2;
                                Sixteen.Name_Create_Method_1 = u.NameCreate1;
                                Sixteen.Name_Create_Method_2 = u.NameCreate2;
                                Q_17_Structures.Structures_Create(Sixteen.Operation_Info_Method_1);
                                Sixteen.Method_Modul_Start_1(a);
                            }
                        }
                    }
                }
                if (Key == 3)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        var Modul_16_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Получение данных из базы:");
                        foreach (Modul_Struct_Base u in Modul_16_1)
                        {
                            Console.WriteLine($"Выполняется поиск строк с полем NameInfo1 = {Generation_Operation.BaseModul(a)}");
                            if (u.NameInfo1 == identification_name)
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
                if (Key == 4)
                {
                    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                    {
                        // Редактирование
                        var Modul_16_1 = db.Modul_Struct_Bases.ToList();
                        Console.WriteLine("Получение данных из базы:");
                        foreach (Modul_Struct_Base u in Modul_16_1)
                        {
                            Console.WriteLine($"Выполняется поиск строк с полем NameInfo1 = {Generation_Operation.BaseModul(a)}");
                            if (u.NameInfo1 == identification_name)
                            {
                                u.OperationInfo1 = "";
                                u.NameCreate1 = "";
                                u.NameCreate2 = "";
                                u.OperationCreate1 = Code_Writer_Console(a, 2);
                                u.OperationCreate2 = Code_Writer_Console(a, 3);
                                db.Modul_Struct_Bases.Update(u);
                            }
                        }
                        db.SaveChanges();                     
                    }
                }
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Days day;   // переменная day
            day = Days.Friday;
            Console.WriteLine(day);
            Console.WriteLine((int)day);
            Console.WriteLine("\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Enumeration_Enum_Create(10, 15, Operation.Add);  // результат 25
            Enumeration_Enum_Create(10, 15, Operation.Multiply); //150
            Console.WriteLine("\n");
        }
    }
}
