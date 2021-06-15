using System;
using Training_Csharp;
//using ConsoleApp2;

namespace Modul_Csharp_Base
{
    class Program 
    {
        static void Main(string[] args) 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                Modul_Struct_Base Modul_1 = new User { Name = "Tom", Age = 33 };
                Modul_Struct_Base Modul_2 = new User { Name = "Alice", Age = 26 };
                Modul_Struct One = new A_1_First_Program();
                // добавляем их в бд
                
                db.Modul_Struct_Base.Add(Modul_1);
                db.Modul_Struct_Base.Add(Modul_2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.Read();
        }
    }
}
