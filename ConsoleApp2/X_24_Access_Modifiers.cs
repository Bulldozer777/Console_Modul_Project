using Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Accounts.User_Accounts;

namespace Training_Csharp
{
    class X_24_Access_Modifiers : Modul_Struct
    {
        public static void X_24_Access_Modifiers_Info(int a)
        {
            if (a == 24)
            {
                Modul_Struct twenty_four = new X_24_Access_Modifiers();
                Modul_Struct_Start_With_DB(a, twenty_four,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1)),
                    NameCreate1_p: "Модификаторы доступа класса Person_X_24 и Employee_X_24",
                    OperationCreate1_p: Code_Writer_Console(a, 3),
                    NameCreate2_p: "Библиотека клсссоав User_Account",
                    OperationCreate2_p: Code_Writer_Console(a, 2),
                    NameCreate3_p: "Модификатор internal",
                    OperationCreate3_p: Code_Writer_Console(a, 4),
                    NameCreate4_p: "Модификатор protected-internal",
                    OperationCreate4_p: Code_Writer_Console(a, 5),
                    NameCreate5_p: "Private class и получение private поле из Private class",
                    OperationCreate5_p: Code_Writer_Console(a, 6));
                //Person_X_24 person = new Person_X_24();
                //person.name = "Tom";
                //person.Display();
                //Console.WriteLine("Модификатор доступа public - доступ возможен с любой точки программы. Противоположный ему модификатор private делает член класса закрытым , переменная может использоваться только в классе вкотором она объявлена ");
                //Console.WriteLine("Модификатор protected - член класса который определен доступен из текущего класса и из класса наследника");
                //Console.WriteLine(Structures_Create("Модификатор internal: класс и члены класса с подобным модификатором доступны из любого места кода в той же сборке, однако он недоступен для других программ и сборок (как в случае с модификатором public)."));
                //Console.WriteLine(Structures_Create("protected internal: совмещает функционал двух модификаторов.Классы и члены класса с таким модификатором доступны из текущей сборки и из производных классов."));
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Person_X_24 person = new Person_X_24();
            person.name = "Tom";
            person.Display();
            Employee_X_24 p = new Employee_X_24();
            p.Display_Employee_X_24();
        }
        public override void Coddition_Create_Type_Method_2()
        {
            User_Accounts user = new User_Accounts();

            //класс наследник может находиться в другом преокте 

            user.age = 10;
            user.Display();
        }
        public override void Coddition_Create_Type_Method_3()
        {
            User_Accounts user = new User_Accounts();

            //user.name1 = "Tom"; ошибка т к мы объявляем переменную вне проекта Accounts
            X_24_Account_User m = new X_24_Account_User();
            Console.WriteLine(m.User_Accounts_Create() + "\n");
        }
        public override void Coddition_Create_Type_Method_4()
        {
            X_24_Account_User m = new X_24_Account_User();
            m.Display_1();

        }
        public override void Coddition_Create_Type_Method_5()
        {
            int a = 24;
            Console.WriteLine("Введите 1 чтобы, запустить методы, которые получают приватное поле из приватного класса");
            int key = int.Parse(Console.ReadLine());
            if (key == 1)
            {
                Console.WriteLine("Поле с модификаторм private можно получить, создавая public методы и,\nиспользуя private поле в этих методах\n");
                Console.WriteLine($"Код методов:\n \n{Code_Writer_Console(a, 7)}\n");
                Console.WriteLine($"Результат работы методов:\n");
                Person_X_24 o = new Person_X_24();
                o.Method_Modificator_private();
            }
            else
            Create_Method(a);
        }
    }
    class Person_X_24
    {
        public int age; //если не определно модификаторов то по умолчанию стоит модификатор private 
        public string name;
        protected string horda; //наследование horda
        public void Display()
        {
            Console.WriteLine($"{name}\n");
        }
        public void Method_Modificator_private()
        {
           Person_X_24_Account o = new Person_X_24_Account();
           o.Modificator_private();
        }
        private class Person_X_24_Account
        {
            //класс можно определить внутри другого класса и
            //тогда можно использовать для класса модификатор доступа private
            //private class Employee_X_24 : Person_X_24 
            //Ошибка
            //Класс использаемые в пространстве имен
            //можно определить только с модификатором public
            //либо по умолчанию модификатор internal,
            //другие модификаторы нельзя использовать - ошибка
            //Ошибка CS1527  Элементы, определенные в пространстве имен,
            //нельзя объявлять в явном виде как частные, защищенные,
            //защищенные внутренние или частные защищенные

            private string password;
            public void Modificator_private()
            {
                password = "root";
                Console.WriteLine(password + "\n");
            }
        }
    }
   class Employee_X_24 : Person_X_24 // по умолчанию класс имеет модификатор internal 
    {
        public void Display_Employee_X_24()
        {
            Console.WriteLine($"{horda}"); //наследование horda
        }
    }
}
