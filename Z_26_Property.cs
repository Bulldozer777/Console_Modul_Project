using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_26_Property : Modul_Struct
    {
        public static void Z_26_Property_Info(int a)
        {
            if (a == 26)
            {
                Modul_Struct twenty_six = new Z_26_Property();
                Modul_Struct_Start_With_DB(a, twenty_six,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1)
                    + Code_Writer_Console(a, 2),
                    NameCreate1_p: "Свойство FirstName класса Person_Z_26",
                    OperationCreate1_p: Code_Writer_Console(a, 3),
                    NameCreate2_p: "Свойство Age класса Person_Z_26, с изменением блока set",
                    OperationCreate2_p: Code_Writer_Console(a, 4),
                    NameCreate3_p: "Свойство LastName класса Person_Z_26, с изменением блока get",
                    OperationCreate3_p: Code_Writer_Console(a, 5),
                    NameCreate4_p: "Свойство FullName класса Person_Z_26, сиспользованием только блока get",
                    OperationCreate4_p: Code_Writer_Console(a, 6),
                    NameCreate5_p: "Свойство Age... с комбинацией логики в блоках get и set",
                    OperationCreate5_p: Code_Writer_Console(a, 7));       
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Person_Z_26 person = new Person_Z_26();
            person.FirstName = "Tom";
            string name = person.FirstName;
            Console.WriteLine(name + "\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Person_Z_26 person = new Person_Z_26();
            person.Age = 23;
            person.Age = 20000;

            //недопустимое значение

            Console.WriteLine(person.Age + "\n");

            //будет возвращать предудущие значение, которые допустимы, исходя из условия
        }
        public override void Coddition_Create_Type_Method_3()
        {
            Person_Z_26 person = new Person_Z_26();
            person.LastName = "Smith";

            //string name1 = person.LastName; 
            // некорректная запись т к определен только блок set в свойстве
            
            Console.WriteLine("Смотреть код метода, вывод \"person.LastName\" невозможен\n");
        }
        public override void Coddition_Create_Type_Method_4()
        {
            Person_Z_26 person = new Person_Z_26();
  
            //string name1 = person.LastName; // некорректная запись т к определен только блок set в свойстве           
            //person.FullName = "Tom Smith";// некорректная запись т к мы можем только получить get

            Console.WriteLine(person.FullName + "\n");

            //получаем значение 
        }
        public override void Coddition_Create_Type_Method_5()
        {
            Person_Z_26 person = new Person_Z_26();
            person.Age1 = 45;
            int r = person.Age1;

            //person.Age5 = 35; некорректначя запись, блок set недоступен
            person.Age2 = 10;
            int i = person.Age2;
            Console.WriteLine($"person.Age1 - {r} \n person.Age2 - {i}");
        }
    }
    class Person_Z_26
    {
        //возможна запись конструктора ctor + двойной tab
        public Person_Z_26() //констурктор, будет нужен в случае, если поле set будет с модификатором private для заполнения поля класса Age
        {
            Age = 34;
        }
        public int Age1 { get; set; } = 56;

        //сокращенная запись свойства подобное Age2
        // можно присваивать значения в свойство таким образом как выше, тоже самое что 
        // private int age3 = 56;
        // public int Age3
        // {
        //    get { return age3; }
        //    set { age3 = value; }
        // }
        // можно использовать модификаторы доступа для его блоков get и set , пример age4
        //private int age4 = 56;
        //public int Age4
        //{
        //    get { return age4; }
        //    private set { age4 = value; } из вне класса person мы не сможем установить свойство age
        //}
        //можем убрать блок get или set в сокращенной записи
        //public int Age6 { get; } = 56;

        public int Age5 { get; private set; } = 56;//тоже самое модификаторы ставятся для блоков свойства в сокращенной записи
        private int age;
        public int Age2
        {
            get { return age; }
            set { age = value; }
        }
        private string firstName; 

        //поле приватное 
        public string FirstName  

            //свойство 
            // как правило с большой буквы

        {
            get { return firstName; } 

            //возвращение значение свойства блок get 
            // т к свойство управляет дотупом к полю то 

            set { firstName = value; } 

            //установка значения блок set 
            // то значение которое пердается свойству доступно через ключевое слово value 
        }
        public int Age {
            get { return age; }
            set { if (value >= 0 && value < 99)
                {

                    age = value;
                } }
        }
        public string lastName;
        public string LastName   //свойство 
                                  // как правило с большой буквы
        {
            set { lastName = value; }      
        }
        public string FullName   //свойство 
                                 // как правило с большой буквы

        {

            get { return $"{firstName} {lastName}"; } 
           
        }
        public int MyProperty { get; set; }

    }
}
