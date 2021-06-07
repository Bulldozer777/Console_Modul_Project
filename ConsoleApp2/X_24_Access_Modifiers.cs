using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class X_24_Access_Modifiers
    {
        public static void X_24_Access_Modifiers_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 24)
            {
                Person_X_24 person = new Person_X_24();
                person.name = "Tom";
                person.Display();
                Console.WriteLine("Модификатор доступа public - доступ возможен с любой точки программы. Противоположный ему модификатор private делает член класса закрытым , переменная может использоваться только в классе вкотором она объявлена ");
                Console.WriteLine("Модификатор protected - член класса который определен доступен из текущего класса и из класса наследника");
                Console.WriteLine(Q_17_Structures.Structures_Create("Модификатор internal: класс и члены класса с подобным модификатором доступны из любого места кода в той же сборке, однако он недоступен для других программ и сборок (как в случае с модификатором public)."));
                Console.WriteLine(Q_17_Structures.Structures_Create("protected internal: совмещает функционал двух модификаторов.Классы и члены класса с таким модификатором доступны из текущей сборки и из производных классов."));
            }
            Program.EndInStart();
        }
        public static void X_24_Access_Modifiers_Create(int a)
        {
          
        }
    }
    class Person_X_24
    {
        public int age; //если не определно модификаторов то по умолчанию стоит модификатор private 
        public string name;
        protected string horda; //наследование horda
        public void Display()
        {
            Console.WriteLine($"{name}");
        }
        private class Person_X_24_Account //класс можно определить внутри другого класса и тогда можно использовать для класса модификатор доступа private
        {
            private string password;
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
