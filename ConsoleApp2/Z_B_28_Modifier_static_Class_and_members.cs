using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Z_B_28_Modifier_static_Class_and_members
    {
        public static void Z_B_28_Modifier_static_Class_and_members_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 28)
            {
              //  Math.Min(4,6);
               // Math o = new Math(); статический класс, нельзя создать объект класса

                Account acc1 = new Account(1000, 6);
                Account acc2 = new Account(900, 5);
                Account.MinSum = 200;
                Console.WriteLine( Account.GetSum(1000, 10, 5));
                //Console.WriteLine(acc1.GetSum(1000,10,5));
                //Console.WriteLine(acc1.GetSum(1000, 10, 5));
                //for (int i = 0; i < 10; i++)  //можно циклом фор создавать объекты класса
                //{
                //    Z_B_28_User user1 = new Z_B_28_User();
                //}
                  Z_B_28_User user1 = new Z_B_28_User();
                Z_B_28_User user2 = new Z_B_28_User();
                Z_B_28_User user3 = new Z_B_28_User();
                Z_B_28_User user4 = new Z_B_28_User();
                Z_B_28_User user5 = new Z_B_28_User();
                Z_B_28_User.Z_B_28_Display();
                Console.WriteLine(user1.Id);   //можно переделать структуру всей программы
                Console.WriteLine(user2.Id);
                Console.WriteLine(user3.Id);
                Console.WriteLine(user4.Id);
                Console.WriteLine(user5.Id);

            }
            Program.EndInStart();
        }
    }
    class Z_B_28_User
    {
        private static int counter = 0;
        public Z_B_28_User()
        {
           Id = ++counter;
        }
        public static void Z_B_28_Display()
        {
             Console.WriteLine($"{counter}");
        }
        public int Id { get; set; } //свойство записывается prob + двойной tab
    }
    class Account
    {
        private static decimal minSum = 100; //минимальная сумма для счетов
        public Account(decimal sum, decimal rate) //конструктор принмает сумму на счет и процентную ставку
        {
            if (sum < MinSum) throw new Exception("Недопустимая сумма"); //если меньше, то выбрасывается исключение
            //иначе
            Sum = sum; Rate = rate; //устанавливаем значения для sum и rate
        }
        public static decimal MinSum //для того чтоб управлять доступом к переменной
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; } //свойство процентной ставки 
        public static decimal GetSum(decimal sum, decimal rate, int period) // посчет суммы через определенный период по некоторой процентной ставке
        {
            decimal result = sum;
            for (int i = 0; i <= period; i++)
            {
                result = result + result * rate / 100;
            }
            return result;
        }
    }
}
