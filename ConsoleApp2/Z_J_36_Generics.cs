using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_J_36_Generics : Modul_Struct
    {
        public static void Z_J_36_Generics_Info(int a)
        {
            if (a == 36)
            {
                Modul_Struct thirty_six = new Z_J_36_Generics();
                Modul_Struct_Start_With_DB(a, thirty_six,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Упаковка и Распаковка",
                    OperationCreate1_p: Code_Writer_Console(a, 1), 
                    NameCreate2_p: "Обобщения универсальны параметр <T> ",
                    OperationCreate2_p: Code_Writer_Console(a, 1),
                    NameCreate3_p: "Передача нескольких обощенных параметров",
                    OperationCreate3_p: Code_Writer_Console(a, 1),
                    NameCreate4_p: "Обобщенный методы, метод Swap",
                    OperationCreate4_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_J_36_Generics_Create()
        {

        }
        public override void Coddition_Create_Type_Method_1()
        {
            Z_J_36_Account acc1 = new Z_J_36_Account();
            Z_J_36_Account acc2 = new Z_J_36_Account();
            acc1.Id = 45; //упаковка , преобразовние к типу инт в тип обджект
            acc2.Id = "5876";
            int intId = (int)acc1.Id; //распаковка, преобразование типа обджект к значимому типу
            string strId = (string)acc2.Id;
            Console.WriteLine($"acc1 : {intId} acc2: {strId}\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Z_J_36_Account_1<int> acc1 = new Z_J_36_Account_1<int>();
            Z_J_36_Account_1<string> acc2 = new Z_J_36_Account_1<string>();
            acc1.Id = 45; // здесь нет упаковки и распоковка и повышается производительность приложения 
            acc2.Id = "5876";
            int intId = acc1.Id; 
            string strId = acc2.Id;
            Console.WriteLine($"acc1 : {intId} acc2: {strId}\n");
        }
        public override void Coddition_Create_Type_Method_3()
        {
            Z_J_36_Account_1<int> acc1 = new Z_J_36_Account_1<int>();
            Z_J_36_Account_1<string> acc2 = new Z_J_36_Account_1<string>();
            Z_J_36_Account_1<int> acc3 = new Z_J_36_Account_1<int>();
            acc1.Id = 45432; // здесь нет упаковки и распоковка и повышается производительность приложения 
            acc2.Id = "5876";
            int intId = acc1.Id;
            string strId = acc2.Id;
            Console.WriteLine($"acc1 : {intId} acc2: {strId}");
            Transaction<Z_J_36_Account_1<int>, string> operation = 
                new Transaction<Z_J_36_Account_1<int>, string>()
                { 
                    FromAccount = acc1 ,
                    ToAccount = acc3 ,
                    Code = "3453425"
                };
            Transaction<int, string> operation1 =
               new Transaction<int, string>()
               {
                   FromAccount = 2354,
                   ToAccount = 643,
                   Code = "3453425"
               };
            Console.WriteLine($" operation.FromAccount = { operation.FromAccount}");
            Console.WriteLine($" operation1.FromAccount = { operation1.FromAccount}");
            Console.WriteLine($" operation.ToAccount = { operation.ToAccount}");
            Console.WriteLine($" operation1.ToAccount = { operation1.ToAccount}");
            Console.WriteLine($" operation.Code = { operation.Code}");
            Console.WriteLine($" operation1.Code = { operation1.Code}\n");
        }
        public override void Coddition_Create_Type_Method_4()
        {
            int x = 34;
            int y = 6;
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x = {x} y = {y}\n");     
            
            string s1 = "23542";         
            string s2 = "srgtreg";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1 = {s1}  s2 = {s2}\n");
        }
        public void Swap<T>(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        class Z_J_36_Account
        {
            public object Id { get; set; } //определяем общий тип обджект (универсальный тип от которого наследуются все типы)
            //т к айди может подтягиваться в разных типах поэтому тип обджект 
            public int Sum { get; set; }
        }
        class Z_J_36_Id
        {

        }
        class Z_J_36_Account_1<T>
        {
            public T Id { get; set; } //определяем общий тип обджект (универсальный тип от которого наследуются все типы)
            //т к айди может подтягиваться в разных типах поэтому тип обджект 
            public int Sum { get; set; }
        }
        class Z_J_36_Id_1
        {

        }
        class Transaction <U, V>
        {
            public U FromAccount{ get; set; }
            public U ToAccount { get; set; }
            public V Code { get; set; }
        }
    }
}
