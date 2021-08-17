using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_F_32_Polymorphism_And_Method_Redefinition : Modul_Struct
    {
        public static void Z_F_32_Polymorphism_And_Method_Redefinition_Info(int a)
        {
            if (a == 32)
            {
                Modul_Struct thirty_two = new Z_F_32_Polymorphism_And_Method_Redefinition();
                Modul_Struct_Start_With_DB(a, thirty_two,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Z_F_32_Person p1 = new Z_F_32_Person("Bill", "Gates");
            p1.Display();
            Z_F_32_Person p2 = new Z_F_32_Employee("Tom", "Smith", "Microfoft");
            p2.Display();
            Z_F_32_Employee p3 = new Z_F_32_Employee("Bob", "Tompson", "Apple");
            p3.Display();
        }
        public static void Z_F_32_Polymorphism_And_Method_Redefinition_Create()
        {

        }
        class Z_F_32_Employee : Z_F_32_Person
        {
            private string _company;
            public Z_F_32_Employee(string name, string surname, string comp)
                : base(name, surname)
            {
                Company = comp;
            }
            public string Company
            {
                get { return _company; }
                set { _company = value; }
            }
            //Можно двумя способами , второй способ через ключевое слово base
            //public override void Display()
            //{
            //    Console.WriteLine(FirstName + " " + LastName + "work in" + Company);
            //}     
            //Было так 

            //public override void Display()
            //{
            //    base.Display();
            //Console.WriteLine("Work in" + Company);
            //}

            //Происходит сокрытие реализации метода
            //Сокрытие в производном классе функциональности базового
            public new void Display()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        class Z_F_32_Person
        {
            private string _firstName;
            private string _lastName;
            public Z_F_32_Person(string name, string surname)
            {
                _firstName = name;
                _lastName = surname;
            }
            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }
            public virtual string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }
            public virtual void Display()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }

            //Запрет на переопределение sealed или убрать ключевое слово virtual

            //public virtual sealed void Display()
            //{
            //    Console.WriteLine(FirstName + " " + LastName);
            //}

            
            //public new void Display1()
            //{
            //    Console.WriteLine(FirstName + " " + LastName);
            //}
        }
        //Цепь наследования person - employee - manager
        class Z_F_32_Manager : Z_F_32_Employee
        {
            public Z_F_32_Manager(string name, string surname, string comp)
                :base(name, surname, comp)
            {

            }
            //При сокрытии не работает переопредление в классе наследуемом от наследуемого где применено сокрытие
            //public override void Display()
            //{
            //    Console.WriteLine("This is Manager");
            //}

        }
    }
}
