using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_H_34_The_Object_Class_And_Its_Methods : Modul_Struct
    {
        public static void Z_H_34_The_Object_Class_And_Its_Methods_Info(int a)
        {
            if (a == 34)
            {
                Modul_Struct thirty_four = new Z_H_34_The_Object_Class_And_Its_Methods();             
                Modul_Struct_Start_With_DB(a, thirty_four,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_H_34_The_Object_Class_And_Its_Methods_Create()
        {

        }
        public override void Coddition_Create_Type_Method_1()
        {
            Z_H_34_Person person = new Z_H_34_Person { Name = "Tom" };
            Console.WriteLine(person.ToString());
            Clock clock = new Clock { Hours = 15, Minutes = 34, Seconds = 23 };
            Console.WriteLine(clock);
               
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Z_H_34_Person person = new Z_H_34_Person { Name = "Tom" };
            Z_H_34_Person person1 = new Z_H_34_Person { Name = "Tom" };
            Z_H_34_Person person2 = new Z_H_34_Person { Name = "TOM" };

            Console.WriteLine($"{person.GetHashCode()}\n");
            Console.WriteLine($"{person1.GetHashCode()}\n");
            Console.WriteLine($"{person2.GetHashCode()}\n");

        }
        public override void Coddition_Create_Type_Method_3()
        {
            Z_H_34_Person person = new Z_H_34_Person { Name = "Tom" };
            object person1 = new Z_H_34_Person { Name = "Tom" };

            Console.WriteLine($"{person.GetType()}\n");
            Console.WriteLine($"{person1.GetType()}\n");
        

        }
        public override void Coddition_Create_Type_Method_4()
        {
            Z_H_34_Person person = new Z_H_34_Person { Name = "Tom" };
            Z_H_34_Person person1 = new Z_H_34_Person { Name = "Tom" };
            Z_H_34_Person person2 = new Z_H_34_Person { Name = "Bob" };

            Console.WriteLine($"{person.Equals(person1)}\n");
            Console.WriteLine($"{person1.Equals(person2)}\n");


        }
        class Clock
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            public override string ToString()
            {
                return $"{Hours}:{Minutes}:{Seconds}";
            }
        }
        class Z_H_34_Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                if (String.IsNullOrEmpty(Name))
                {
                    return base.ToString();
                }
                return Name;
            }
            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj.GetType() != this.GetType()) return false;
                Z_H_34_Person person = (Z_H_34_Person)obj;
                return this.Name == person.Name && this.Age == person.Age;
            }
        }
    }
}
