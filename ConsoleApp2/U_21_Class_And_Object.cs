using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Training_Csharp
{
    class U_21_Class_And_Object : Modul_Struct
    {
        public static void Class_And_Object_Info(int a)
        {
            if (a == 21)
            {
                // Create_Directory_Modul(); //создает 43 папки в каждую из которых добавляет по 10 файлов

                //  User_Person tom; //чтобы работать с переменной надо создать объект
                //User_Person tom = new User_Person("Bob"); //создание объекта
                //                                     //User_Person()- конструктор по умолчанию
                //                                     //Если конструктор создан, то контруктор по умолчанию уже нельзя использовать и
                //                                     //надо заполнять при создании конструктор созданный в классе
                //tom.name = "Tom";
                //tom.age = 22;
                //tom.Info();
                //User_Person bob = new User_Person("Tom") { age = 26 }; //инициализатор { age = 26 }
                //bob.name = "Bob";
                //bob.age = 22;
                //bob.Info();
                User_Person tom = new User_Person("Bob");
                tom.name = "Bob";
                tom.Info();
                //Modul_Struct Modul_Name = new Modul_Struct();
                Console.WriteLine("\nПример работы класса Modul_Struct:\n");
                //name_Info_Method_1 = "Modul_Name_Info";
                //name_Create_Method_2 = "Modul_Name_Create";
                //name_Tasks_Method_3 = "Modul_Name_Tascks";
                //name_Examples_Method_4 = "Modul_Name_Examples";
                string m = "Как правило, для создания программ на C# разработчики используют Visual Studio или какие-то другие IDE типа Rider от компании JetBrains. Но все подобные IDE, хотя и облегчают разработку, в то же время скрывают множество мельчайших подробностей по созданию программ. И в реальности мы даже можем обойтись без той же Visual Studio, используя только инфраструктуру .NET Core CLI. Рассмотрим, как использовать .NET Core CLI и компилировать приложение из командной строки. Поэтому создадим на диске C какую-нибудь новую папку для проекта. Назовем ее, к примеру, helloapp.Откроем командную строку и с помощью команды cd перейдем к этой папке. Для создания проекта в .NET Core CLI применяется команда dotnet new, которой передается название проекта. Итак, в введем в командной строке следующую команду";
                Q_17_Structures.Structures_Create(m);
                Modul_Struct l = new Modul_Struct();
                //      Modul_Struct Class_U21 = new Modul_Struct { operation_Info_Method_1 = "1", operation_Create_Method_2 = "using System;\nnamespace helloapp\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\nConsole.WriteLine(\"Hello World!\");\n}\n}\n}", operation_Tasks_Method_3 = "using System;\nnamespace helloapp\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\nConsole.WriteLine(\"Привет мир, задача!\");Console.WriteLine(\"решаем и тренируемся!\");\n}\n}\n}", operation_Examples_Method_4 = "В задаче выше решается как вывести 2 раза надпись на консоль" } ;
                //Modul_Struct Class_U22 = new Modul_Struct  (m, "using System;\nnamespace helloapp\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\nConsole.WriteLine(\"Hello World!\");\n}\n}\n}", "using System;\nnamespace helloapp\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\nConsole.WriteLine(\"Привет мир, задача!\");Console.WriteLine(\"решаем и тренируемся!\");\n}\n}\n}", "В задаче выше решается как вывести 2 раза надпись на консоль" );
                operation_Info_Method_1 = m; //либо поля класса статические, либо создается обЬект класса , выше создание
                operation_Create_Method_2 = "using System;\nnamespace helloapp\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\nConsole.WriteLine(\"Hello World!\");\n}\n}\n}";
                operation_Tasks_Method_3 = "using System;\nnamespace helloapp\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\nConsole.WriteLine(\"Привет мир, задача!\");Console.WriteLine(\"решаем и тренируемся!\");\n}\n}\n}";
                operation_Examples_Method_4 = "В задаче выше решается как вывести 2 раза надпись на консоль";
              //  Method_Modul_Start_1();
            }
            Generation_Operation.EndInStart();
        }
        public static void Class_And_Object_Method()
        {
          
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
    class Modul_Struct
    {
        //public delegate void Method_Void();
        //public Method_Void void_method_Examples;
        //void_method_Examples = I_9_Cycles.Method_Void;       
        public static string name_Info_Method_1;  //сюда вводятся имена методов, используемые в Create_Method()
        public static string name_Create_Method_1;
        public static string name_Create_Method_2;
        public static string name_Create_Method_3;
        public static string name_Create_Method_4;
        public static string name_Create_Method_5;
        public static string name_Tasks_Method_3;
        public static string name_Examples_Method_1; //сюда вводятся имена методов, используемые в Examples_Method()
        public static string name_Examples_Method_2;
        public static string name_Examples_Method_3;
        public static string name_Examples_Method_4;  
        public static string name_Examples_Method_5;
        public static string operation_Info_Method_1;
        public static string operation_Create_Method_1;
        public static string operation_Create_Method_2;
        public static string operation_Create_Method_3;
        public static string operation_Create_Method_4;
        public static string operation_Create_Method_5;
        public static string operation_Tasks_Method_1;
        public static string operation_Tasks_Method_2;
        public static string operation_Tasks_Method_3;
        public static string operation_Tasks_Method_4;
        public static string operation_Tasks_Method_5;
        public static string operation_Examples_Method_1; //сюда вводятся методы, работа которых используется в Examples_Method()
        public static string operation_Examples_Method_2;
        public static string operation_Examples_Method_3;
        public static string operation_Examples_Method_4;
        public static string operation_Examples_Method_5;
        public static string operation_Examples_Method_6;
        public static string operation_Examples_Method_7;
        public static string create_Create_Method_1;
        public static string create_Create_Method_2;
        public static string create_Create_Method_3;
        public static string create_Create_Method_4;
        public static string create_Create_Method_5;
        public static string create_Create_Method_6;
        public static string create_Examples_Method_1;
        public static string create_Examples_Method_2;
        public static string create_Examples_Method_3;
        public static string create_Examples_Method_4;
        public static string create_Examples_Method_5;
        public static string create_Examples_Method_6;
        public static object m2;
        //public Modul_Struct(string name_Create_Method_1, string operation_Create_Method_1, string create_Create_Method_1)
        //{
        //    this.name_Create_Method_1 = name_Create_Method_1;
        //    this.operation_Create_Method_1 = operation_Create_Method_1;
        //    this.create_Create_Method_1 = create_Create_Method_1;
        //}
        //public Modul_Struct(string operation_Info_Method_1, string operation_Create_Method_2, string operation_Tasks_Method_3, string operation_Examples_Method_4)
        //{
        //    this.operation_Info_Method_1 = operation_Info_Method_1;
        //    this.operation_Create_Method_2 = operation_Create_Method_2;
        //    this.operation_Tasks_Method_3 = operation_Tasks_Method_3;
        //    this.operation_Examples_Method_4 = operation_Examples_Method_4;
        //}
        public static void Method_Modul_Start()
        {
            Console.WriteLine("\n");
            //if (operation_Info_Method_1 == null & operation_Create_Method_1 == null & operation_Tasks_Method_1 == null & operation_Examples_Method_1 == null)
            //{
            //    Console.WriteLine("Не заполнено ни одно поле класса Modul_Struct, заполните поля класса для запуска модуля");
            //}
            if (operation_Info_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить Info_Method нажмите 1 ");
            }
            if (operation_Create_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить Create_Method нажмите 2 ");
            }
            if (operation_Tasks_Method_1 != null)
            { 
                Console.WriteLine($"Чтобы запустить Tasks_Method нажмите 3 ");
            }
            if (operation_Examples_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить Examples_Method нажмите 4 ");
            }
            Console.WriteLine("Чтобы перейти в выбору другого модуля нажмите 5");

        }
        public static void M1(object Modul_Struct)
        {
            Console.WriteLine(Modul_Struct);
        }
        public virtual void Method_Modul_Start_1()
        {
            if (operation_Info_Method_1 == null & operation_Create_Method_1 == null & operation_Tasks_Method_1 == null & operation_Examples_Method_1 == null)
            {
                Console.WriteLine("\nПустой модуль");
                Console.WriteLine("Не заполнено ни одно поле класса Modul_Struct, заполните поля класса для запуска модуля");
            }
            Method_Modul_Start();
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.Clear();
                Info_Method();
                Method_Modul_Start_1();
            }
            if (x == 2)
            {
                Console.Clear();
                Create_Method();
                Method_Modul_Start_1();
            }
            if (x == 3)
            {
                Console.Clear();
                Tasks_Method();
                Method_Modul_Start_1();
            }
            if (x == 4)
            {
                Console.Clear();
                Examples_Method();
                Method_Modul_Start_1();
            }
            if (x == 5)
            {
                Generation_Operation.EndInStart();
            }
            if (x > 5 || x < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-5, чтобы запустить необходимый метод");
                Method_Modul_Start_1();
            }
        }
      //  public int MyProperty { get; set; }
        public static void Info_Method()
        {
            Console.WriteLine($"{operation_Info_Method_1}");
        }
        public virtual void Create_Method()
        {
            if (name_Create_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить {name_Create_Method_1} нажмите 1 ");
            }
            if (name_Create_Method_2 != null)
            {
                Console.WriteLine($"Чтобы запустить {name_Create_Method_2} нажмите 2 ");
            }
                if (name_Create_Method_3 != null)
                {
                    Console.WriteLine($"Чтобы запустить {name_Create_Method_3} нажмите 3 ");
                }
                    if (name_Create_Method_4 != null)
                    {
                        Console.WriteLine($"Чтобы запустить {name_Create_Method_4} нажмите 4 ");
                    }
                        if (name_Create_Method_5 != null)
                        {
                            Console.WriteLine($"Чтобы запустить {name_Create_Method_5} нажмите 5 ");
                        }
            Console.WriteLine("Чтобы перейти в выбору другогой темы модуля модуля нажмите 6");
            Console.WriteLine("Чтобы перейти в выбору другого модуля модуля нажмите 7");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Coddition_Create_1();
            }
            if (x == 2)
            {
                Coddition_Create_2();
            }
            if (x == 3)
            {
                Coddition_Create_3();
            }
            if (x == 4)
            {
                Coddition_Create_4();
            }
            if (x == 5)
            {
                Coddition_Create_5();
            }
            if (x == 6)
            {
                Console.Clear();
                Method_Modul_Start_1();
            }
            if (x == 7)
            {
                Console.Clear();
                Generation_Operation.EndInStart();
            }

            if (x > 7 || x < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-7, чтобы запустить необходимый метод");
                Method_Modul_Start_1();
            }
        }
        public virtual void Coddition_Create_1()
        {
                Console.Clear();
                Console.WriteLine($"{operation_Create_Method_1}");
                Console.WriteLine($"Вывод результата работы метода \"{name_Create_Method_1}\" на консоль \n");
                Coddition_Create_Type_Method_1();
                Create_Method();
        }
        public virtual void Coddition_Create_Type_Method_1()
        {         
            Console.WriteLine($"{create_Create_Method_1}");          
        }
        public virtual void Coddition_Create_2()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Create_Method_2}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Create_Method_2}\" на консоль \n");
            Coddition_Create_Type_Method_2();
            Create_Method();
        }
        public virtual void Coddition_Create_Type_Method_2()
        {
            Console.WriteLine($"{create_Create_Method_2}");
        }
        public virtual void Coddition_Create_3()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Create_Method_3}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Create_Method_3}\" на консоль \n");
            Coddition_Create_Type_Method_3();
            Create_Method();
        }
        public virtual void Coddition_Create_Type_Method_3()
        {
            Console.WriteLine($"{create_Create_Method_3}");
        }
        public virtual void Coddition_Create_4()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Create_Method_4}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Create_Method_4}\" на консоль \n");
            Coddition_Create_Type_Method_4();
            Create_Method();
        }
        public virtual void Coddition_Create_Type_Method_4()
        {
            Console.WriteLine($"{create_Create_Method_4}");
        }
        public virtual void Coddition_Create_5()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Create_Method_5}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Create_Method_5}\" на консоль \n");
            Coddition_Create_Type_Method_5();
            Create_Method();
        }
        public virtual void Coddition_Create_Type_Method_5()
        {
            Console.WriteLine($"{create_Create_Method_5}");
        }

        public virtual void Tasks_Method()
        {
            Console.WriteLine($"{operation_Tasks_Method_3}");
        }
        public virtual void Examples_Method()
        {
            if (name_Examples_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить {name_Examples_Method_1} нажмите 1 ");
            }
            if (name_Examples_Method_2 != null)
            {
                Console.WriteLine($"Чтобы запустить {name_Examples_Method_2} нажмите 2 ");
            }
            if (name_Examples_Method_3 != null)
            {
                Console.WriteLine($"Чтобы запустить {name_Examples_Method_3} нажмите 3 ");
            }
            if (name_Examples_Method_4 != null)
            {
                Console.WriteLine($"Чтобы запустить {name_Examples_Method_4} нажмите 4 ");
            }
            if (name_Examples_Method_5 != null)
            {
                Console.WriteLine($"Чтобы запустить {name_Examples_Method_5} нажмите 5 ");
            }
            Console.WriteLine("Чтобы перейти в выбору другогой темы модуля модуля нажмите 6");
            Console.WriteLine("Чтобы перейти в выбору другого модуля модуля нажмите 7");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Coddition_Examples_1();
            }
            if (x == 2)
            {
                Coddition_Examples_2();
            }
            if (x == 3)
            {
                Coddition_Examples_3();
            }
            if (x == 4)
            {
                Coddition_Examples_4();
            }
            if (x == 5)
            {
                Coddition_Examples_5();
            }
            if (x == 6)
            {
                Console.Clear();
                Method_Modul_Start_1();
            }
            if (x == 7)
            {
                Console.Clear();
                Generation_Operation.EndInStart();
            }

            if (x > 7 || x < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-7, чтобы запустить необходимый метод");
                Method_Modul_Start_1();
            }
        }
        public virtual void Coddition_Examples_1()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Examples_Method_1}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_1}\" на консоль \n");
            Coddition_Examples_Type_Method_1();
            Examples_Method();
        }
        public virtual void Coddition_Examples_Type_Method_1()
        {
            Console.WriteLine($"{create_Examples_Method_1}");
        }
        public virtual void Coddition_Examples_2()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Examples_Method_2}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_2}\" на консоль \n");
            Coddition_Examples_Type_Method_2();
            Examples_Method();
        }
        public virtual void Coddition_Examples_Type_Method_2()
        {
            Console.WriteLine($"{create_Examples_Method_2}");
        }
        public virtual void Coddition_Examples_3()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Examples_Method_3}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_3}\" на консоль \n");
            Coddition_Examples_Type_Method_3();
            Examples_Method();
        }
        public virtual void Coddition_Examples_Type_Method_3()
        {
            Console.WriteLine($"{create_Examples_Method_3}");
        }
        public virtual void Coddition_Examples_4()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Examples_Method_4}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_4}\" на консоль \n");
            Coddition_Examples_Type_Method_4();
            Examples_Method();
        }
        public virtual void Coddition_Examples_Type_Method_4()
        {
            Console.WriteLine($"{create_Examples_Method_4}");
        }
        public virtual void Coddition_Examples_5()
        {
            Console.Clear();
            Console.WriteLine($"{operation_Examples_Method_5}");
            Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_5}\" на консоль \n");
            Coddition_Examples_Type_Method_5();
            Examples_Method();
        }
        public virtual void Coddition_Examples_Type_Method_5()
        {
            Console.WriteLine($"{create_Examples_Method_5}");
        }
        public static string Code_Writer_Console(int x, int e)
        {
            string y = Generation_Operation.BaseModul(x);
            y = y.Replace("\n", " ");
            string Way_To_File = "C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2\\For_Method_Code_Writer_Console\\" + y + "\\Модуль " + x + ", номер файла - " + e + ".txt";
            FileStream file1 = new FileStream(Way_To_File, FileMode.Open); //создаем файловый поток
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 
            string Code = reader.ReadToEnd();
            reader.Close();
            return Code;
        }
        public static void Create_File_Modul()
        {
            for (int i = 1; i < 10; i++)
            {
                string y = Generation_Operation.BaseModul(i);
                y = y.Replace("\n", " "); 
                File.Create($"C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2\\For_Method_Code_Writer_Console\\ Модуль 5 Поразрядные операции в языке программирования C#\\Модуль 5 файл с кодом № {i} .txt.txt");
            }
        }
        public static void Create_Directory_Modul() //создает 43 папки в каждую из которых добавляет по 10 файлов, явный пример работы цикла в цикле
        {
            for (int i = 1; i < 44; i++)
            {
                string y = Generation_Operation.BaseModul(i);
                y = y.Replace("\n", " ");
                Directory.CreateDirectory($"C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2\\For_Method_Code_Writer_Console\\{y}");
                //создает 43 папки, в папке с приложением, по теме каждого модуля
                for (int j = 1; j <= 10; j++)
                {
                    File.Create($"C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2\\For_Method_Code_Writer_Console\\{y}\\Модуль {i}, номер файла - {j}.txt");
                }
            }
        }
    }
}
