using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_M_39_Interfaces : Modul_Struct
    {
        public static void Z_M_39_Interfaces_Info(int a)
        {
            if (a == 39)
            {
                Modul_Struct thirty_nine = new Z_M_39_Interfaces();
                Modul_Struct_Start_With_DB(a, thirty_nine,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Интерфейсы",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "3 версии методов",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameCreate3_p: "3 версии методов",
                    OperationCreate3_p: Code_Writer_Console(a, 4),
                    NameCreate4_p: "3 версии методов",
                    OperationCreate4_p: Code_Writer_Console(a, 5)
                    );
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_M_39_Interfaces_Create()
        {

        }
        public override void Coddition_Create_Type_Method_1()
        {
            Z_M_39_Client client = new Z_M_39_Client("Tom", 3000);
            client.Put(500);
            Console.WriteLine(client.CurrentSum);
            client.Withdraw(600);
            Console.WriteLine(client.CurrentSum);

            IZ_M_39_Account client1 = new Z_M_39_Client("Tom", 3000);
            
            //можно определить переменну типа IZ_M_39_Account

            client1.Put(500);
            Console.WriteLine(client1.CurrentSum);
            client1.Withdraw(600);
            Console.WriteLine(client1.CurrentSum);

            Z_M_39_Client client2 = (Z_M_39_Client)client1;

            //вместо операции приведения типов можно использовать оператор as

            Z_M_39_Client client3 = client1 as Z_M_39_Client;

            //все объекты класса Z_M_39_Client
            //являются объектами интерфейса IZ_M_39_Account
            //а обратное неверно,
            //нужно использовать операцию приведения типов

            string name = ((Z_M_39_Client)client).Name;


        }
        public override void Coddition_Create_Type_Method_2()
        {
            
        }
        class Z_M_39_Client : IZ_M_39_Account, IZ_M_39_Client

            //можно реализовывать сколько угодно интерфейсов
            //нельзя менять модификатор иначе оно будет не рализовано

        {
            int _sum;
            public int CurrentSum { get { return _sum; } }

            public string Name { get; set ; }

            public void Put(int sum)
            {
                _sum += sum;
            }
            public void Withdraw(int sum)
            {
                if (_sum >= sum) _sum -= sum;
            }
            public Z_M_39_Client(string name, int sum)
            {
                Name = name; _sum = sum;
            }
        }
        interface IZ_M_39_Account //Интерфейсы принято писать с заглавной буквы I
        {
            int CurrentSum { get; } //не определяются модификаторы доступа
            void Put(int sum);
            void Withdraw(int sum);
        }
        interface IZ_M_39_Client
        {
            string Name { get; set; }
        }   
    }
}
