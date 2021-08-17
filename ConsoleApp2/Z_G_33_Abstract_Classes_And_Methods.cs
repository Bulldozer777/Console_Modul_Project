using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_G_33_Abstract_Classes_And_Methods : Modul_Struct
    {
        public static void Z_G_33_Abstract_Classes_And_Methods_Info(int a)
        {
            if (a == 33)
            {
                Modul_Struct thirty_three = new Z_G_33_Abstract_Classes_And_Methods();
                Modul_Struct_Start_With_DB(a, thirty_three,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_G_33_Abstract_Classes_And_Methods_Create()
        {

        }
        public override void Coddition_Create_Type_Method_1()
        {
            //Z_G_33_Human h = new Z_G_33_Human(); нельзя создать объект абстрактного класса
            //Z_G_33_Person k = new Z_G_33_Person();
            Z_G_33_Client client = new Z_G_33_Client("Tom", "Smith", 500);
            Z_G_33_Employee employee = new Z_G_33_Employee("Bob", "Tompson", "operator");
            Z_G_33_Person client1 = new Z_G_33_Client("Tom", "Smith", 500);
            Z_G_33_Person employee1 = new Z_G_33_Employee("Bob", "Tompson", "operator");
            client.Display();
            employee.Display();
        }
        abstract class Figure
        {
            public abstract float Perimetr();
            public abstract float Square();
        }
        class Rectangle : Figure
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public override float Perimetr()
            {
                return Width * 2 + Height * 2;
            }
            public override float Square()
            {
               return Width * Height;
            }

        }
        abstract class Z_G_33_Human
        {
            public string Name { get; set; }
        }
        abstract class Z_G_33_Person 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Z_G_33_Person(string name, string surname)
            {
                FirstName = name;
                LastName = surname;
            }
            public abstract void Display();
            //{
            //    Console.WriteLine(FirstName + " " + LastName);
            //}
        }
        class Z_G_33_Client : Z_G_33_Person
        {
            public int Sum { get; set; }
            public Z_G_33_Client(string name, string surname, int sum)
                :base(name, surname)
            {
                Sum = sum;
            }
            public override void Display()
            {
                Console.WriteLine($"Client {FirstName}  {LastName}");
            }
        }
       class Z_G_33_Employee : Z_G_33_Person
        {
            public string Position { get; set; }
            public Z_G_33_Employee(string name, string surname, string position)
                 : base(name, surname)
            {
                //FirstName = name;
                //LastName = surname;
                Position = position;
            }
            public override void Display()
            {
                Console.WriteLine($"Employee {FirstName}  {LastName}");
            }
        }
        
    }
}
