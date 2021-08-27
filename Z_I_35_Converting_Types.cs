using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_I_35_Converting_Types : Modul_Struct
    {
        public static void Z_I_35_Converting_Types_Info(int a)
        {
            if (a == 35)
            {
                Modul_Struct thirty_five = new Z_I_35_Converting_Types();
                Modul_Struct_Start_With_DB(a, thirty_five,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Восходящие преобразования\nПреобразование от производного класса к базовому",
                    OperationCreate1_p: Code_Writer_Console(a, 1),
                    NameCreate2_p: "Проверка на правильного преобразования типов, первый способ",
                    OperationCreate2_p: Code_Writer_Console(a, 2),
                    NameCreate3_p: "Проверка на правильного преобразования типов, второй способ",
                    OperationCreate3_p: Code_Writer_Console(a, 3),
                    NameCreate4_p: "Проверка на правильного преобразования типов, третий способ",
                    OperationCreate4_p: Code_Writer_Console(a, 4));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_I_35_Converting_Types_Create()
        {

        }
        public override void Coddition_Create_Type_Method_1()
        {   
            //восходящие преобразования
            object person3 = new Z_I_35_Employee("Tom", "Smith", "Microsoft"); //преобразование от производного класса к базовому
            Z_I_35_Person person1 = new Z_I_35_Employee("Tom", "Smith", "Microsoft"); //преобразование от производного класса к базовому
            Z_I_35_Person person2 = new Z_I_35_Client("Bob", "Tompson", "SomeBank", 5000);
            int sum = ((Z_I_35_Client)person2).Sum;
            string name = ((Z_I_35_Employee)person1).FirstName;
            string company = ((Z_I_35_Employee)person1).Company;
            Console.WriteLine($"{sum}\n");
            Console.WriteLine($"{name}\n");
            Console.WriteLine($"{company}\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            //восходящие преобразования
            object person3 = new Z_I_35_Employee("Tom", "Smith", "Microsoft"); //преобразование от производного класса к базовому
            Z_I_35_Person person1 = new Z_I_35_Employee("Tom", "Smith", "Microsoft"); //преобразование от производного класса к базовому
            Z_I_35_Person person2 = new Z_I_35_Client("Bob", "Tompson", "SomeBank", 5000);

            //низходящие преобразования - преобразование от базовых типов к производным
            Z_I_35_Client client = person1 as Z_I_35_Client;
            Z_I_35_Client client1 = person2 as Z_I_35_Client;
            Console.WriteLine(client);
            Console.WriteLine(client1);
            if(client !=null)

            {      //низходящие преобразования - преобразование от базовых типов к производным
                int sum = client.Sum;
                Console.WriteLine(sum + "\n");
            }
            else
            {
                Console.WriteLine("Преобразование завершилось неудачно\n");
            }
            //Console.WriteLine(company);
        }
        public override void Coddition_Create_Type_Method_3()
        {
        
            Z_I_35_Person person1 = new Z_I_35_Employee("Tom", "Smith", "Microsoft"); //преобразование от производного класса к базовому
            Z_I_35_Person person2 = new Z_I_35_Client("Bob", "Tompson", "SomeBank", 5000);
            try
            {
                //низходящие преобразования - преобразование от базовых типов к производным
                Z_I_35_Client client = (Z_I_35_Client)person1;
                int sum = client.Sum;
                Console.WriteLine(sum + "\n");
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("Преобразование завершилось неудачно\n");
            }
        }
        public override void Coddition_Create_Type_Method_4()
        {
            Z_I_35_Person person1 = new Z_I_35_Employee("Tom", "Smith", "Microsoft"); //преобразование от производного класса к базовому
            Z_I_35_Person person2 = new Z_I_35_Client("Bob", "Tompson", "SomeBank", 5000);
            if (person1 is null)
            {
                //низходящие преобразования - преобразование от базовых типов к производным
                Z_I_35_Client client = (Z_I_35_Client)person1;
                int sum = client.Sum;
                Console.WriteLine(sum + "\n");
            }
            else
            {
                Console.WriteLine("Преобразование завершилось неудачно\n");
            }
        }
        abstract class Z_I_35_Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Z_I_35_Person(string name, string surname)
            {
                FirstName = name;
                LastName = surname;
            }
            public abstract void Display();
        }
        class Z_I_35_Employee : Z_I_35_Person
        {
            public string Company { get; set; }
            public Z_I_35_Employee(string name, string surname, string comp)
                 : base(name, surname)
            {
                Company = comp;
            }
            public override void Display()
            {
                Console.WriteLine($"Employee {FirstName} {LastName} работает в компании {Company}");
            }
        }
        class Z_I_35_Client : Z_I_35_Person
        {
            public int Sum { get; set; }
            public string Bank { get; set; }
            public Z_I_35_Client(string name, string surname, string bank, int sum)
                : base(name, surname)
            {
                Bank = bank;
                Sum = sum;
            }
            public override void Display()
            {
                Console.WriteLine($"Client {FirstName} {LastName} имеет счет в банке {Bank} на сумму {Sum}");
            }
        }
    }
}
