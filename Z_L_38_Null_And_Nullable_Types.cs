using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_L_38_Null_And_Nullable_Types : Modul_Struct
    {
        public static void Z_L_38_Null_And_Nullable_Types_Info(int a)
        {
            if (a == 38)
            {
                Modul_Struct thirty_eight = new Z_L_38_Null_And_Nullable_Types();
                Modul_Struct_Start_With_DB(a, thirty_eight,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Значение типа Null",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "Передача значения null не ссылочному типу и вывод на консоль",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameCreate3_p: "Оператор null - объединения - ??",
                    OperationCreate3_p: Code_Writer_Console(a, 4)
                    );
            }
            Generation_Operation.EndInStart();
        }
        public override void Info_Method()
        {
            Console.WriteLine(Operation_Info_Method_1);
        }
        public static void Z_L_38_Null_And_Nullable_Types_Create()
        {

        }
        public override void Coddition_Create_1(int a)
        {
            Console.WriteLine("\nРабота метода - Значение типа Null, нажмите 1");
            Console.WriteLine("Код struct Z_L_38_Null_State и Z_K_37_Transaction и  class Z_L_38_Null_Countr, нажмите 2");
            Console.WriteLine("Назад нажмите 3");
            int t = int.Parse(Console.ReadLine());
            if (t == 1)
            {
                base.Coddition_Create_1(a);
            }
            if (t == 2)
            {
                Console.WriteLine(Code_Writer_Console(a, 5));
                Create_Method(a);
            }
            if (t == 3)
            {
                Create_Method(a);
            }
            else
            {
                Console.WriteLine("\nВы ввели неверное число\n");
                Create_Method(a);
            }
        }
        public override void Coddition_Create_Type_Method_1()
        {
            string s = null;
            Z_L_38_Null_Country country = null;

            //значение null может именть только ссылочный тип, класс это ссылочный тип
            //int age = null; int - не ссылочный тип, строка некорректна 
            //тпи int имеет значение по умолчанию 0 

            int? age1 = 5;
            int x = age1.Value;

            //теперь переменная представлет Nullable от int - полная запись System.Nullable<int>

            System.Nullable<int> age2 = null;

            double? d = null;
            d = 3.4;
            Nullable<double> d2 = null; //полная запись

            Z_L_38_Null_State? stateNullable = null; 

            //если оставить значение null то вылетит исключение при запуске

            Nullable<Z_L_38_Null_State> k = null;
            stateNullable = new Z_L_38_Null_State { Name = "Narnia" };

            //Z_L_38_Null_Country? c = null;
            //пременные ссылочных типов допускают null, класс ссылочный тип

            Z_L_38_Null_State state = stateNullable.Value;

            //т к переменная stateNullable представляет Nullable от Z_L_38_Null_State,
            //то обратиться к свойству Name невозможно, можно обраться к свойству Value
            //и присвоить Z_L_38_Null_State state = stateNullable.Value;
            //если выводить stateNullable.Value без присваивания то вывведется
            //Training_Csharp.Z_L_38_Null_And_Nullable_Types+Z_L_38_Null_State

            Console.WriteLine($"{state.Name} \n");
            Console.WriteLine($"{stateNullable.Value} \n"); 

            //Training_Csharp.Z_L_38_Null_And_Nullable_Types+Z_L_38_Null_State

            if(stateNullable.HasValue == true) //если значение определено, то 
            {
                Z_L_38_Null_State state1 = stateNullable.Value;
                Console.WriteLine($"{state1.Name}\n");
            }
            else
            {
                Console.WriteLine("stateNullable is equal to null \n");
            }
        }
        public override void Coddition_Create_Type_Method_2()
        {
            int? age = 5;
            int x = age.GetValueOrDefault();
            Console.WriteLine(x);

            int? age1 = null;
            int x1 = age.GetValueOrDefault();
            Console.WriteLine(x1); //ноль - значение по умолчанию для данного типа       
        }
        public override void Coddition_Create_Type_Method_3()
        {
            int? age = 5;
            //Оператор налл-объединения - ??

            int x2 = age ?? 10;

            //если age = null, то будет возвращаться 10, если age != null,
            //то будет возвращaть значение переменной age

            Console.WriteLine(x2);
            age = null;
            x2 = age ?? 12;
            Console.WriteLine($"{x2}\n");
        }
        struct Z_L_38_Null_State //значение null может именть только ссылочный тип
        {
            public string Name { get; set; }
        }
        class Z_L_38_Null_Country
        {
            public string Name { get; set; }
        }
    }
}
