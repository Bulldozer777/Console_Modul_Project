using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_K_37_Limitations_Of_Generalizations : Modul_Struct
    {
        public static void Z_K_37_Limitations_Of_Generalizations_Info(int a)
        {
            if (a == 37)
            {
                Modul_Struct thirty_seven = new Z_K_37_Limitations_Of_Generalizations();
                Modul_Struct_Start_With_DB(a, thirty_seven,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "Определение ограничения универсального параметра <Т>,\nограничение - класс Z_K_37_Account_1\n",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                    NameCreate2_p: "Определение ограничения универсальных параметров <Т,K>,\nограничение - класс Z_K_37_Account_1 и struct (все)\n",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameCreate3_p: "Определение ограничения универсальных параметров <Т,K>,\nограничение - класс Z_K_37_Account_1 и new()\n",
                    OperationCreate3_p: Code_Writer_Console(a, 4),
                    NameCreate4_p: "Определение ограничения универсальных параметров <Т,K>,\nограничение - класс Z_K_37_Account_1 и class (все)\n",
                    OperationCreate4_p: Code_Writer_Console(a, 5),
                    NameCreate5_p: "Определение ограничения универсальных параметров <Т,K>,\nограничение - класс Z_K_37_Account_1 и class (все)\n",
                    OperationCreate5_p: Code_Writer_Console(a, 7)
                    );
            }
            Generation_Operation.EndInStart();
        }
        public override void Info_Method()
        {
            Console.WriteLine(Operation_Info_Method_1); 
        }
        public static void Z_K_37_Limitations_Of_Generalizations_Create()
        {

        }
        public override void Coddition_Create_1(int a)
        {
            Console.WriteLine("\nРабота методов, нажмите 1");
            Console.WriteLine("Код классов Z_K_37_Account_1 и Z_K_37_Transaction и Z_K_37_DemandAccount, нажмите 2");
            Console.WriteLine("Назад нажмите 3");
            int t = int.Parse(Console.ReadLine());
            if (t == 1)
            {
                base.Coddition_Create_1(a);
            }
            if (t == 2)
            {
                Console.WriteLine(Code_Writer_Console(a, 6)); 
                Create_Method(a);
            }
            if(t == 3)
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
            Z_K_37_Account_1 acc1 = new Z_K_37_Account_1(23) { Sum = 4500 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_Account_1 acc2 = new Z_K_37_Account_1(55) { Sum = 5000 };
            Z_K_37_DemandAccount acc3 = new Z_K_37_DemandAccount(123) { Sum = 4000 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_DemandAccount acc4 = new Z_K_37_DemandAccount(125) { Sum = 3000 };
            Z_K_37_Transaction<Z_K_37_Account_1> t1 = new Z_K_37_Transaction<Z_K_37_Account_1>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 700
            };
            Z_K_37_Transaction<Z_K_37_DemandAccount> t2 = new Z_K_37_Transaction<Z_K_37_DemandAccount>
            {
                FromAccount = acc3,
                ToAccount = acc4,
                Sum = 700   //свойство Sum - из класса  Z_K_37_Transaction
            };
            Z_K_37_DemandAccount u = t2.FromAccount;
            t1.Execute();
            t2.Execute();
            Console.WriteLine($"{u}\n");
        }
        public void Start_Generics()
        {

        }
        public override void Coddition_Create_Type_Method_2()
        {
            Z_K_37_Account_1 acc1 = new Z_K_37_Account_1(23) { Sum = 4500 };
            Z_K_37_Account_1 acc2 = new Z_K_37_Account_1(55) { Sum = 5000 };
            Z_K_37_DemandAccount acc3 = new Z_K_37_DemandAccount(123) { Sum = 4000 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_DemandAccount acc4 = new Z_K_37_DemandAccount(125) { Sum = 3000 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_Transaction_1<Z_K_37_Account_1, int> t3 = new Z_K_37_Transaction_1<Z_K_37_Account_1, int>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 700
            };
            Z_K_37_Transaction_1<Z_K_37_Account_1, int> t4 = new Z_K_37_Transaction_1<Z_K_37_Account_1, int>
            {
                FromAccount = acc3,
                ToAccount = acc4,
                Sum = 700 //свойство Sum - из класса  Z_K_37_Transaction_1
            };
            t3.Execute();
            t4.Execute();
        }
        public override void Coddition_Create_Type_Method_3()
        {
            Z_K_37_Account_1 acc1 = new Z_K_37_Account_1(23) { Sum = 4500 };
            Z_K_37_Account_1 acc2 = new Z_K_37_Account_1(55) { Sum = 5000 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_DemandAccount acc3 = new Z_K_37_DemandAccount(123) { Sum = 4000 };
            Z_K_37_DemandAccount acc4 = new Z_K_37_DemandAccount(125) { Sum = 3000 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_Transaction_2<Z_K_37_Account_1, int> t3 = new Z_K_37_Transaction_2<Z_K_37_Account_1, int>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 700
            };
            Z_K_37_Transaction_2<Z_K_37_Account_1, int> t4 = new Z_K_37_Transaction_2<Z_K_37_Account_1, int>
            {
                FromAccount = acc3,
                ToAccount = acc4,
                Sum = 700 //свойство Sum - из класса  Z_K_37_Transaction_2
            };
            t3.Execute();
            t4.Execute();
        }
        public override void Coddition_Create_Type_Method_4()
        {
            Z_K_37_Account_1 acc1 = new Z_K_37_Account_1(23) { Sum = 4500 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_Account_1 acc2 = new Z_K_37_Account_1(55) { Sum = 5000 };
            Z_K_37_DemandAccount acc3 = new Z_K_37_DemandAccount(123) { Sum = 4000 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_DemandAccount acc4 = new Z_K_37_DemandAccount(125) { Sum = 3000 };
            Z_K_37_Transaction_3<Z_K_37_Account_1, Modul_Struct> t3 = new Z_K_37_Transaction_3<Z_K_37_Account_1, Modul_Struct>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 700
            };
            Z_K_37_Transaction_3<Z_K_37_Account_1, Modul_Struct> t4 = new()
            {
                FromAccount = acc3,
                ToAccount = acc4,
                Sum = 700  //свойство Sum - из класса  Z_K_37_Transaction_3 
            };
            t3.Execute();
            t4.Execute();
        }
        public override void Coddition_Create_Type_Method_5()
        {
            Z_K_37_Account_1 acc1 = new Z_K_37_Account_1(23) { Sum = 4500 }; //свойство Sum - из класса  Z_K_37_Account_1 
            Z_K_37_Account_1 acc2 = new Z_K_37_Account_1(55) { Sum = 5000 };
            Transact<Z_K_37_Account_1>(acc1, acc2, 900);
        }
        class Z_K_37_Transaction<T> where T : Z_K_37_Account_1 //ограничение типа (тип только объекты класса аккаунт) 

            //значит свойства FromAccount и ToAccount имеют тип Z_K_37_Account_1

        {
            public T FromAccount { get; set; }     //с какого счета перевод
            public T ToAccount { get; set; }     // на какой счет перевод
            public int Sum { get; set; } // сумма перевода
            // выполняем перевод
            public void Execute()
            {
                if(FromAccount.Sum > Sum)
                {
                    FromAccount.Sum -= Sum;
                    ToAccount.Sum += Sum;
                    Console.WriteLine($"{FromAccount.Id} : {FromAccount.Sum}\n" +
                        $"{ToAccount.Id} : {ToAccount.Sum} \n");
                }
            }
        }
        class Z_K_37_Transaction_1<T, K> 
              where T : Z_K_37_Account_1
            where K : struct
            //ограничение типа (тип только объекты класса аккаунт) 

            //значит свойства FromAccount и ToAccount имеют тип Z_K_37_Account_1

        {
            public T FromAccount { get; set; }     //с какого счета перевод
            public T ToAccount { get; set; }     // на какой счет перевод
            public int Sum { get; set; } // сумма перевода
            // выполняем перевод
            public void Execute()
            {
                if (FromAccount.Sum > Sum)
                {
                    FromAccount.Sum -= Sum;
                    ToAccount.Sum += Sum;
                    Console.WriteLine($"{FromAccount.Id} : {FromAccount.Sum}\n" +
                        $"{ToAccount.Id} : {ToAccount.Sum} \n");
                }
            }
        }
        class Z_K_37_Transaction_2<T, K> 
            where T : Z_K_37_Account_1 
            where K : new() //ограничение типа (тип только объекты класса аккаунт) 

            //значит свойства FromAccount и ToAccount имеют тип Z_K_37_Account_1

        {
            public T FromAccount { get; set; }     //с какого счета перевод
            public T ToAccount { get; set; }     // на какой счет перевод
            public int Sum { get; set; } // сумма перевода
            // выполняем перевод
            public void Execute()
            {
                if (FromAccount.Sum > Sum)
                {
                    FromAccount.Sum -= Sum;
                    ToAccount.Sum += Sum;
                    Console.WriteLine($"{FromAccount.Id} : {FromAccount.Sum}\n" +
                        $"{ToAccount.Id} : {ToAccount.Sum} \n");
                }
            }
        }
        class Z_K_37_Transaction_3<T, K>
           where T : Z_K_37_Account_1
           where K : class   //ограничение типа (тип только объекты класса аккаунт) 

            //значит свойства FromAccount и ToAccount имеют тип Z_K_37_Account_1

        {
            public T FromAccount { get; set; }     //с какого счета перевод
            public T ToAccount { get; set; }     // на какой счет перевод
            public int Sum { get; set; } // сумма перевода
            // выполняем перевод
            public void Execute()
            {
                if (FromAccount.Sum > Sum)
                {
                    FromAccount.Sum -= Sum;
                    ToAccount.Sum += Sum;
                    Console.WriteLine($"{FromAccount.Id} : {FromAccount.Sum}\n" +
                        $"{ToAccount.Id} : {ToAccount.Sum} \n");
                }
            }
        }
         class Z_K_37_Account_1
        {
            public int Id { get; }
            public int Sum { get; set; }

            public Z_K_37_Account_1(int id)
            {
                Id = id;
            }
            public Z_K_37_Account_1() //конструктор по умолчанию, 
                                      //обязателен, если в универсальный параметр передается new()
            {

            }
        }
        class Z_K_37_DemandAccount : Z_K_37_Account_1
        {
            public Z_K_37_DemandAccount(int id) : base(id)
            { }
            public Z_K_37_DemandAccount() //конструктор по умолчанию, 
                                          //обязателен, если в универсальный параметр передается new()
            {

            }
        }
          static void Transact<T>(T acc1, T acc2, int sum) where T : Z_K_37_Account_1
        {
            if (acc1.Sum > sum)
            {
                acc1.Sum -= sum;
                acc2.Sum += sum;
                Console.WriteLine($"{acc1.Id} : {acc1.Sum}\n" +
                    $"{acc2.Id} : {acc2.Sum} \n");
            }
        }
    }
}
