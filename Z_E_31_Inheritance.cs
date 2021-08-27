using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_E_31_Inheritance : Modul_Struct
    {
        public static void Z_E_31_Inheritance_Info(int a)
        {
            if (a == 31)
            {
                Modul_Struct thirty_one = new Z_E_31_Inheritance();
                Modul_Struct_Start_With_DB(a, thirty_one,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Наследование класса Emloyee_31 : Person_31",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }

        public override void Coddition_Create_Type_Method_1()
        {
            //Person_31 p = new Person_31 { LastName = "Getes", FirstName = "Bill" };
            //Emloyee_31 emp = new Emloyee_31 { FirstName = "Tom", LastName = "Smith", Company = "Microsoft"};
            Person_31 p = new Person_31 ("Getes", "Bill" );
            Emloyee_31 emp = new Emloyee_31 ("Tom", "Smith", "Microsoft" );

            //emp.FirstName;
            //можно обращаться к полям, свойствам и методам наследуемого класса
            //emp.LastName;
            //class Emloyee_31 : Person_31, Manager - некорректная запись
            //c# не поддерживает множественное наследование

            emp.Display();
            p.Display();

        }
        public override void Coddition_Create_Type_Method_2()
        {
            

        }
        class Person_31  

            //класс с ключевым словом sealed class Person_31                      
            //класс от который запрещает операцию наследования

        {
            private string _firstName;

            //нельзя обратиться т к модификатор private

            private string _lastName;
            public string FirstName {
                get { return _firstName; }
                set { _firstName = value; }
            }
            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }
            public void Display()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }

            //если определен конструктор то его надо записать в классе наследнике
            public Person_31(string name , string surname) 
            {
                _firstName = name; _lastName = surname;
            }
            public Person_31()
            {
                _firstName = " "; 

            }
        }
        class Emloyee_31 : Person_31
        {
            //private string _firstName;
            //private string _lastName;
            private string _company;
            //public string LastName
            //{
            //    get { return _lastName; }
            //    set { _lastName = value; }
            //}
            //public string FirstName
            //{
            //    get { return _firstName; }
            //    set { _firstName = value; }
            //}

            public Emloyee_31 (string name, string surname, string comp)

                //:base (name, surname)
                //можно не вызывать конструктор от базового ,
                //если определен конструктор без параметров

            {
                Company = comp;
                FirstName = name; LastName = surname;

                //тогда придется вводить
                //_firstName = name; _lastName = surname;  
            }

            //:base (name, surname) 
            //Наследование от базового конструктора


            public string Company
            {
                get { return _company; }
                set { _company = value; }
            }
            //public void Display()
            //{
            //    Console.WriteLine(FirstName + " " + LastName);
            //}
        }
    }
}
