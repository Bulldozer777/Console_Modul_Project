using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;

namespace Training_Csharp
{
    class U_21_Class_And_Object : Modul_Struct
    {
        public static void Class_And_Object_Info(int a)
        {
            if (a == 21)
            {
                Modul_Struct twenty_one = new U_21_Class_And_Object();
                Modul_Struct_Start_With_DB(a, twenty_one,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1)),
                    NameCreate1_p: "Cоздание объекта класса и заполнение конструктора по умолчанию",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "Использование определенного конструктора",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameCreate3_p: "Применение ключевого слова this",
                    OperationCreate3_p: Code_Writer_Console(a, 4),
                    NameCreate4_p: "Применение инициализатора",
                    OperationCreate4_p: Code_Writer_Console(a, 5),
                    NameExamples1_p: "",
                    OperationExamples1_p: Code_Writer_Console(a, 6)
                    );
                // Create_Directory_Modul(); //создает 43 папки в каждую из которых добавляет по 10 файлов


                User_Person tom = new User_Person("Bob");
                tom.name = "Bob";
                tom.Info();
            }
            Generation_Operation.EndInStart();
        }
            public override void Coddition_Create_Type_Method_1()
        {
            /* User_Person tom;*/ //чтобы работать с переменной надо создать объект
            User_Person tom = new User_Person("Bob"); //создание объекта
                                                      //User_Person()- конструктор по умолчанию
                                                      //Если конструктор создан, то контруктор по умолчанию уже нельзя использовать и
                                                      //надо заполнять при создании конструктор созданный в классе
            tom.name = "Tom";
            tom.age = 22;
            tom.Info();
        }
        public override void Coddition_Create_Type_Method_2()
        {
            User_Person tom = new User_Person("Bob", 30);
            //использование опредленного конструктора
            tom.Info();
            User_Person tom1 = new User_Person("Artur");
            //не заполнено поле возраст 
            tom1.Info();        
        }
        public override void Coddition_Create_Type_Method_3()
        {
            User_Person tom = new User_Person("Bob", 30);
            //использование опредленного конструктора
            tom.Info();
            User_Person tom1 = new User_Person("Artur");
            //не заполнено поле возраст 
            tom1.Info();
        }
        public override void Coddition_Create_Type_Method_4()
        {
            User_Person bob = new User_Person("Tom") { age = 26 }; //инициализатор { age = 26 }
            bob.Info();

            User_Person bob1 = new User_Person{ name = "Bob", age = 26 }; //инициализатор { age = 26 }
            bob1.Info();
        }
    }
    class User_Person
    {
        public string name;
        public int age;
       // ключевое слово this
       //допустим в конструкторе в параметрах , имя переменной такое же как имя поля и чтобы их различать
       //ключевое слово this представляет ссылку на текущий объект данного класса , теперь компилятор все поймет где параметр, а где поле класса
        public User_Person(string name) //1 конструктор
        {
            this.name = name;
        }
        public User_Person() 
        {            
        }
        public User_Person(string n, int a) : this(n) //когда будет вызываться 2 конструктор - он будет вызывать 1 конструктор
                                                      //в котором будет устанавливаться значение name поэтому можно убрать инструкцию name в 3 конструкторе 
        {
            name = n; //можно этот код убрать т к благодаря this используется 1 конструктор
            age = a;
        }
        public void Check()
        {
            if (name != null)
            {

            }
        }
        public void Info()
        {
            if (name != null)
            {
                Console.WriteLine($"{name}");
            }
            if (age != 0)
            {
                Console.WriteLine($"{age}");
            }       
        }
    }
    
}
