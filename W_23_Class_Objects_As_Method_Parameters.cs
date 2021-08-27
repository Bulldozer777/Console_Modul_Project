using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class W_23_Class_Objects_As_Method_Parameters : Modul_Struct
    {
        public static void W_23_Class_Objects_As_Method_Parameters_Info(int a)
        {
            if (a == 23)
            {
                Modul_Struct twenty_three = new W_23_Class_Objects_As_Method_Parameters();
                Modul_Struct_Start_With_DB(a, twenty_three,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1))
                    + Code_Writer_Console(a, 2)
                    + Structures_Create(Code_Writer_Console(a, 3))
                    + Code_Writer_Console(a, 4),
                    NameCreate1_p: "Передача параметров в метод по значению (структуры User)",
                    OperationCreate1_p: Code_Writer_Console(a, 5),
                    NameCreate2_p: "Передача параметров в метод по ссылке (структуры User)",
                    OperationCreate2_p: Code_Writer_Console(a, 6),
                    NameCreate3_p: "Передача параметров в метод по значению (класса Person)",
                    OperationCreate3_p: Code_Writer_Console(a, 7),
                    NameCreate4_p: "Передача параметров в метод по ссылке (класса Person)",
                    OperationCreate4_p: Code_Writer_Console(a, 8));
                    //NameCreate5_p: "Ссылочные типы внутри типов значений",
                    //OperationCreate5_p: Code_Writer_Console(a, 6),
                    //NameExamples1_p: "",
                    //OperationExamples1_p: Code_Writer_Console(a, 6));
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            User_W_23 user1 = new User_W_23 { name = "Tom", age = 23 };
            ChangeUser(user1);  // метод ничего не сделает т к работает с копией 
            Console.WriteLine($"{user1.name} - {user1.age}\n"); // Tom 23
        }
        public override void Coddition_Create_Type_Method_2()
        {
            User_W_23 user1 = new User_W_23 { name = "Tom", age = 23 };
            ChangeUser1(ref user1); // метод сработает т к параметр передается по ссылке с помощью ключевого слово ref, меняется сам объект в памяти,
                                    // объект user1 изменился
            Console.WriteLine($"{user1.name} - {user1.age}\n"); // Bob 33
        }
        public override void Coddition_Create_Type_Method_3()
        {
            Person_W_23 person1 = new Person_W_23 { name = "Dadlick", age = 25 };
            ChangePerson(person1); 

            // метод сработает т к это объект класса, а класс это ссылочный тип ,
            // переменная person1 хранит ссылку на объект в куче (heat)

            Console.WriteLine($"{person1.name} - {person1.age}\n");
        }
        public override void Coddition_Create_Type_Method_4()
        {
            Person_W_23 person1 = new Person_W_23 { name = "Dadlick", age = 25 };
            ChangePerson1(ref person1);
            Console.WriteLine($"{person1.name} - {person1.age}\n");
        }
        static void ChangeUser(User_W_23 user)
        {
            user.name = "Bob";
            user.age = 33;
        }
        static void ChangeUser1(ref User_W_23 user)
        {
            user.name = "Bob";
            user.age = 33;
        }
        static void ChangePerson(Person_W_23 person)
        {
            person.name = "Bob";
            person.age = 33;
            person = new Person_W_23 { name = "Down", age = 45 }; //конструктор не сработает , инициализация никак не сказлась, 
            // когда мы используем конструктор для создания объекта в куче создается новый объект ,
            // параметр person будет указывать на новый объект в куче, а выше созданный person1 указывает на старый объект в куче
            //поэтому вызов конструктора ни как не повлияет на переменную person1
        }
        static void ChangePerson1(ref Person_W_23 person)
        {
            person.name = "Bob";
            person.age = 33;
            person = new Person_W_23 { name = "Down", age = 45 }; 

            //конструктор сработает , при передачи парметра по ссылке мы можем изменить не только поля 
            // но и сам объект в памяти            
        }
    }
    struct User_W_23
    {
        public int age;
        public string name;
    }
   class Person_W_23
    {
        public int age;
        public string name;
    }
}
