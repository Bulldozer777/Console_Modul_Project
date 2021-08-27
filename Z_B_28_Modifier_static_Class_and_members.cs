using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_B_28_Modifier_static_Class_and_members : Modul_Struct
    {
        public static void Z_B_28_Modifier_static_Class_and_members_Info(int a)
        {
            if (a == 28)
            {
                Modul_Struct twenty_eight = new Z_B_28_Modifier_static_Class_and_members();
                Modul_Struct_Start_With_DB(a, twenty_eight,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1)),
                    NameCreate1_p: "Модификатор static для представления общего поведения для всех объектов класса Account",
                    OperationCreate1_p: Code_Writer_Console(a, 2),
                     NameCreate2_p: "Модификатор static для представления общего поведения для всех объектов класса Account",
                    OperationCreate2_p: Code_Writer_Console(a, 3),
                    NameExamples1_p: "Модификатор static для представления общего поведения для всех объектов класса Account",
                    OperationExamples1_p: Code_Writer_Console(a, 4)
                    );
                //  Math.Min(4,6);
                // Math o = new Math(); статический класс, нельзя создать объект класса                  
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Account acc1 = new Account(1000, 6);
            Account acc2 = new Account(900, 5);
            Account.MinSum = 200;

            //меняется значение поля minSum для всех объектов Account т к
            //cвойство MinSum и поле minSum имеет модификатор static
            //нельзя использовать нестатические свойства в статических методах
            //нельзя использовать ключевое слово this
            //т к метод статические и работает для всех объектов в целом

            Console.WriteLine(Account.GetSum(1000, 10, 5) + "\n"); 
        }
        public override void Coddition_Create_Type_Method_2()
        {
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
            //Console.WriteLine(Z_B_28_User.Id);
            //Modul_Struct twenty_eight = new Modul_Struct();
            //twenty_eight.Name_Create_Method_1 = "1";
            //Z_B_28_User.Create_Modul_Name_Method_1(Z_B_28_User.Id, out Name_Create_Method_1);
        }
        public override void Coddition_Examples_Type_Method_1()
        {
            Z_B_28_User user1 = new Z_B_28_User();
            for (int i = 0; i < 10; i++)  //можно циклом фор создавать объекты класса
            {
                user1 = new Z_B_28_User();
            }
            Console.WriteLine("Значение счетчика создания объектов класса \"Z_B_28_User\"\n");
            Z_B_28_User.Z_B_28_Display();
            Console.WriteLine("\nВывод значения свойства Id для объекта user1\n");
            Console.WriteLine($"{user1.Id}\n");

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

        //public static void Create_Modul_Name_Method_1(int Id, out string name_Create_Method_1)
        //{
        //    string f = "в языке программирования C#";
        //    List<string> numbers = new List<string>(){ "Первая программа", "Компиляция в командной строке", "Переменные и типы данных"
        //            , "Арифметические операции", "Поразрядные операции", "Преобразования базовых типов данных",
        //        "Условные выражения", "Условные конструкции", "Циклы", "Массивы", "Методы", "Параметры метода",
        //    "Ключевое слово params и массив параметров", "Область видимости переменных", "Рекурсивные функции",
        //    "Перечисления enum", "Структуры", "Кортежи", "Обработка исключений", "Переменные-ссылки и получение ссылки",
        //   "Классы и объекты", "Типы значений и ссылочные типы", "Объекты классов как параметры методов",
        //    "Модификаторы доступа", "Константы и поля для чтения", "Свойства", "Перегрузка методов",
        //        "Модификатор static. Статические классы и члены классов", "Перегрузка операторов",
        //   "Перегрузка операций преобразования типов","Наследование","Полиморфизм и переопределение методов",
        //   "Абстрактные классы и методы","Класс Object и его методы","Преобразование типов","Обобщения (generics)",
        //   "Ограничения обобщений","Null и типы Nullable","Интерфейсы","Делегаты","События","Анонимные методы",
        //   "Лямбда-выражения","Перегрузка операторов"   };
        //    string Modul_Name = "";
        //    //ref string nRef_1 = ref Variables_Links(numbers, 1);
        //    if (Id > 0 && Id < 45)
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //        {
        //            numbers[i] = numbers[i] + " " + f;
        //            Modul_Name = "\n" + "Модуль" + " " + Id + "\n" + Variables_Links_1(numbers, Id) + "\n";
        //            List<Modul_Struct> Modul_Struct = new List<Modul_Struct>()
        //    {
        //      new Modul_Struct {name_Create_Method_1 = Modul_Name}
        //    };

        //        }
        //    }
        //    //List<Modul_Struct> Modul_Struct = new List<Modul_Struct>()
        //    //{
        //    //  new Modul_Struct {name_Create_Method_1 = Modul_Name}
        //    //};

        //}
        //public static string Variables_Links_1(List<string> numbers, int Id)
        //{
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        if (i + 1 == Id)
        //        {
        //            return numbers[i];
        //        }
        //    }
        //    throw new Exception("число не найдено");
        //    //не все ветви кода возвращают значение
        //    //поэтому сгенерируем исключение
        //    //передав в конструктор Exception("число не найдено")
        //}
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
