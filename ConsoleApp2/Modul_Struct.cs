using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;

namespace Training_Csharp
{
    class Modul_Struct
    {
        public static object m2;   // для данного поля пока не написана логика     
        public string Name_Info_Method_1 { get; set; }    // для данного поля пока не написана логика 
        //используется для сопоставление темы и записи в базе данных 
        public string Operation_Info_Method_1 { get; set; }  //поле для ввода текста - объяснения или вступленния, по теме модуля
        public string Name_Create_Method_1 { get; set; } //сюда вводятся имена методов, используемые в CreateMethod()
        public string Name_Create_Method_2 { get; set; }
        public string Name_Create_Method_3 { get; set; }
        public string Name_Create_Method_4 { get; set; }
        public string Name_Create_Method_5 { get; set; }
        public string Name_Tasks_Method_3 { get; set; }   // для данного поля пока не написана логика 
        public string Name_Examples_Method_1 { get; set; } //сюда вводятся имена методов, используемые в Examples_Method()
        public string Name_Examples_Method_2 { get; set; }
        public string Name_Examples_Method_3 { get; set; }
        public string Name_Examples_Method_4 { get; set; }
        public string Name_Examples_Method_5 { get; set; }
        public string Operation_Create_Method_1 { get; set; }     //сюда вводится код методов CreateMethod()
        public string Operation_Create_Method_2 { get; set; }
        public string Operation_Create_Method_3 { get; set; }
        public string Operation_Create_Method_4 { get; set; }
        public string Operation_Create_Method_5 { get; set; }
        public string Operation_Tasks_Method_1 { get; set; }
        public string Operation_Tasks_Method_2 { get; set; }
        public string Operation_Tasks_Method_3 { get; set; }
        public string Operation_Tasks_Method_4 { get; set; }
        public string Operation_Tasks_Method_5 { get; set; }
        public string Operation_Examples_Method_1 { get; set; } //сюда вводятся методы, работа которых используется в Examples_Method()
        public string Operation_Examples_Method_2 { get; set; }
        public string Operation_Examples_Method_3 { get; set; }
        public string Operation_Examples_Method_4 { get; set; }
        public string Operation_Examples_Method_5 { get; set; }
        public string Operation_Examples_Method_6 { get; set; }
        public string Operation_Examples_Method_7 { get; set; }
        public string Create_Create_Method_1 { get; set; }
        public string Create_Create_Method_2 { get; set; }
        public string Create_Create_Method_3 { get; set; }
        public string Create_Create_Method_4 { get; set; }
        public string Create_Create_Method_5 { get; set; }
        public string Create_Create_Method_6 { get; set; }
        public string Create_Examples_Method_1 { get; set; }
        public string Create_Examples_Method_2 { get; set; }
        public string Create_Examples_Method_3 { get; set; }
        public string Create_Examples_Method_4 { get; set; }
        public string Create_Examples_Method_5 { get; set; }
        public string Create_Examples_Method_6 { get; set; }

        public string Name_Create_Method_7 { get; set; }
        public string Operation_Create_Method_7 { get; set; }
        public (string, int) Create_Create_Method_7 { get; set; }

        public int? Create_Create_Method_7_int { get; set; }

        public string Create_Create_Method_7_string { get; set; }

        public int Create_Create_Method_7_int2 { get; set; }

        public static void Start_Modul_Create()
        {
            Console.WriteLine(" Введите 1, для заполнения базы," +
                "\n Введите 2, для получения данных из базы, исходя из совпадения значения столбца NameInfo1" +
                "\n Введите 3, для удаления данных из базы, исходя из совпадения значения столбца NameInfo1" +
                "\n Введите 4, чтобы перейти назад к выбору модуля");
        }

        //public static void List_Modul_Struct()
        //{
        //    using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
        //    {

        //        List < Modul_Struct_Base > = new List<Modul_Struct_Base>();
        //    }
        //    return List < Modul_Struct > nameof;
        //}
        public static void Modul_Struct_Start_With_DB(int a, Modul_Struct Name, string OperationInfo1_p = null, string NameCreate1_p = null,
            string NameCreate2_p = null, string NameCreate3_p = null, string NameCreate4_p = null, string NameCreate5_p = null,
            string NameExamples1_p = null, string NameExamples2_p = null, string NameExamples3_p = null, string NameExamples4_p = null,
            string NameExamples5_p = null,
            string OperationCreate1_p = null, string OperationCreate2_p = null, string OperationCreate3_p = null, string OperationCreate4_p = null,
            string OperationCreate5_p = null,
            string OperationTasks1_p = null, string OperationTasks2_p = null, string OperationTasks3_p = null, string OperationTasks4_p = null,
            string OperationTasks5_p = null,
            string OperationExamples1_p = null, string OperationExamples2_p = null, string OperationExamples3_p = null,
            string OperationExamples4_p = null, string OperationExamples5_p = null, string OperationExamples6_p = null,
            string OperationExamples7_p = null,
            string CreateCreate1_p = null, string CreateCreate2_p = null, string CreateCreate3_p = null,
            string CreateCreate4_p = null, string CreateCreate5_p = null, string CreateCreate6_p = null,
            string CreateExamples1_p = null, string CreateExamples2_p = null,
            string CreateExamples3_p = null, string CreateExamples4_p = null,
              string CreateExamples5_p = null, string CreateExamples6_p = null)
        {
            Start_Modul_Create();
            int key = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    {
                        using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                        {
                            Console.Clear();
                            Modul_Struct_Base Razen = new Modul_Struct_Base
                            {
                                NameInfo1 = Generation_Operation.BaseModul(a),
                                NameCreate1 = NameCreate1_p,
                                NameCreate2 = NameCreate2_p,
                                NameCreate3 = NameCreate3_p,
                                NameCreate4 = NameCreate4_p,
                                NameCreate5 = NameCreate5_p,
                                NameExamples1 = NameExamples1_p, //сюда вводятся имена методов, используемые в Examples_Method()
                                NameExamples2 = NameExamples2_p,
                                NameExamples3 = NameExamples3_p,
                                NameExamples4 = NameExamples4_p,
                                NameExamples5 = NameExamples5_p,
                                OperationInfo1 = OperationInfo1_p,
                                OperationCreate1 = OperationCreate1_p,
                                OperationCreate2 = OperationCreate2_p,
                                OperationCreate3 = OperationCreate3_p,
                                OperationCreate4 = OperationCreate4_p,
                                OperationCreate5 = OperationCreate5_p,
                                OperationTasks1 = OperationTasks1_p,
                                OperationTasks2 = OperationTasks2_p,
                                OperationTasks3 = OperationTasks3_p,
                                OperationTasks4 = OperationTasks4_p,
                                OperationTasks5 = OperationTasks5_p,
                                OperationExamples1 = OperationExamples1_p,   //сюда вводятся методы, работа которых используется в Examples_Method()
                                OperationExamples2 = OperationExamples2_p,
                                OperationExamples3 = OperationExamples3_p,
                                OperationExamples4 = OperationExamples4_p,
                                OperationExamples5 = OperationExamples5_p,
                                OperationExamples6 = OperationExamples6_p,
                                OperationExamples7 = OperationExamples7_p,
                                CreateCreate1 = CreateCreate1_p,
                                CreateCreate2 = CreateCreate2_p,
                                CreateCreate3 = CreateCreate3_p,
                                CreateCreate4 = CreateCreate4_p,
                                CreateCreate5 = CreateCreate5_p,
                                CreateCreate6 = CreateCreate6_p,
                                CreateExamples1 = CreateExamples1_p,
                                CreateExamples2 = CreateExamples2_p,
                                CreateExamples3 = CreateExamples3_p,
                                CreateExamples4 = CreateExamples4_p,
                                CreateExamples5 = CreateExamples5_p,
                                CreateExamples6 = CreateExamples6_p,
                            };
                            Console.Clear();
                            O_15_Recursive_Functions.Add_Modul_Struct_Bases(Razen, Program.Base_Configuration_On_File_Json());
                            Console.WriteLine("\nДобавление данных в базу выполненено успешно");
                            //Console.Clear();
                            Generation_Operation.InStart3(a);
                        }
                    }
                    break;
                case 2:
                    {
                        using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                        {
                            Console.Clear();
                            var Razen = db.Modul_Struct_Bases.ToList();
                            Console.WriteLine("\nПолучение данных из базы \"Modul_Struct_Base\":\n");
                            Console.WriteLine($"{Generation_Operation.BaseModul(a)}");
                            foreach (Modul_Struct_Base u in Razen)
                            {
                                if (u.NameInfo1 == Generation_Operation.BaseModul(a))
                                {
                                    db.Modul_Struct_Bases.Update(u);
                                    Name.Name_Create_Method_1 = u.NameCreate1;
                                    Name.Name_Create_Method_2 = u.NameCreate2;
                                    Name.Name_Create_Method_3 = u.NameCreate3;
                                    Name.Name_Create_Method_4 = u.NameCreate4;
                                    Name.Name_Create_Method_5 = u.NameCreate5;
                                    Name.Name_Examples_Method_1 = u.NameExamples1; //сюда вводятся имена методов, используемые в Examples_Method()
                                    Name.Name_Examples_Method_2 = u.NameExamples2;
                                    Name.Name_Examples_Method_3 = u.NameExamples3;
                                    Name.Name_Examples_Method_4 = u.NameExamples4;
                                    Name.Name_Examples_Method_5 = u.NameExamples5;
                                    Name.Operation_Info_Method_1 = u.OperationInfo1;
                                    Name.Operation_Create_Method_1 = u.OperationCreate1;
                                    Name.Operation_Create_Method_2 = u.OperationCreate2;
                                    Name.Operation_Create_Method_3 = u.OperationCreate3;
                                    Name.Operation_Create_Method_4 = u.OperationCreate4;
                                    Name.Operation_Create_Method_5 = u.OperationCreate5;
                                    Name.Operation_Tasks_Method_1 = u.OperationTasks1;
                                    Name.Operation_Tasks_Method_2 = u.OperationTasks2;
                                    Name.Operation_Tasks_Method_3 = u.OperationTasks3;
                                    Name.Operation_Tasks_Method_4 = u.OperationTasks4;
                                    Name.Operation_Tasks_Method_5 = u.OperationTasks5;
                                    Name.Operation_Examples_Method_1 = u.OperationExamples1;   //сюда вводятся методы, работа которых используется в Examples_Method()
                                    Name.Operation_Examples_Method_2 = u.OperationExamples2;
                                    Name.Operation_Examples_Method_3 = u.OperationExamples3;
                                    Name.Operation_Examples_Method_4 = u.OperationExamples4;
                                    Name.Operation_Examples_Method_5 = u.OperationExamples5;
                                    Name.Operation_Examples_Method_6 = u.OperationExamples6;
                                    Name.Operation_Examples_Method_7 = u.OperationExamples7;
                                    Name.Create_Create_Method_1 = u.CreateCreate1;
                                    Name.Create_Create_Method_2 = u.CreateCreate2;
                                    Name.Create_Create_Method_3 = u.CreateCreate3;
                                    Name.Create_Create_Method_4 = u.CreateCreate4;
                                    Name.Create_Create_Method_5 = u.CreateCreate5;
                                    Name.Create_Create_Method_6 = u.CreateCreate6;
                                    Name.Create_Examples_Method_1 = u.CreateExamples1;
                                    Name.Create_Examples_Method_2 = u.CreateExamples2;
                                    Name.Create_Examples_Method_3 = u.CreateExamples3;
                                    Name.Create_Examples_Method_4 = u.CreateExamples4;
                                    Name.Create_Examples_Method_5 = u.CreateExamples5;
                                    Name.Create_Examples_Method_6 = u.CreateExamples6;
                                    Name.Method_Modul_Start_1(a);
                                    Generation_Operation.InStart3(a);
                                }
                            }
                            foreach (Modul_Struct_Base u in Razen)
                            {
                                if (u.NameInfo1 == Generation_Operation.BaseModul(a))
                                {
                                    Name.Method_Modul_Start_1(a);
                                }
                                if (u.NameInfo1 == null)
                                {
                                    db.Modul_Struct_Bases.Update(u);
                                    string name_of_modul = Generation_Operation.BaseModul(a);
                                    string modul = "Модуль " + a + "\n";
                                    name_of_modul = name_of_modul.Replace(modul, "");
                                    Console.WriteLine($"\nВ базе Modul_Struct_Base по теме:\n\"{name_of_modul}\" - нет данных :(");
                                    Generation_Operation.InStart3(a);
                                }
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        using (ApplicationContext db = new ApplicationContext(Program.Base_Configuration_On_File_Json()))
                        {
//                            string[] mass_count = new string[] {"Первый", "Второй", "Третий", "Четвертый", "Пятый", "Шестой", "Седьмой",
//"восьмое ", "девятое ", "десятый ", "одиннадцатый ", "двенадцатые ", "тринадцатые ",
//"четырнадцатый ", "пятнадцатый ", "шестнадцатый ", "семнадцатый ", "восемнадцать ", "девятнадцать ",
//"двадцатый ", "двадцать первый ", "двадцать вторый ", "двадцать третье ", "двадцать четвёртый ", "двадцать пятый ",
//"двадцать шестый ", "двадцать седьмый ", "двадцать восьмый ", "двадцать девятое ", "тридцатое ", "тридцать первое ",
//"тридцать второй", "тридцать третий", "тридцать четвертый", "тридцать пятый", "тридцать шестой", "тридцать седьмой",
//" ", " ", " ", " ", " ", " ",
//" ", " ", " ", " ", " ", " "
//                            };
                            //int count = mass_count.Length;
                            int count = 0;
                            //int count1 = mass_count.Length;
                            //mass_count.Length = count;
                            var Modul_16_1 = db.Modul_Struct_Bases.ToList();
                            Console.WriteLine("Получение данных из базы:");
                            foreach (Modul_Struct_Base u in Modul_16_1)
                            {
                                count++;
                                //count1 = count - 1 ;
                                Console.Clear();
                                Console.WriteLine($"Выполняется {count} поиск строк с полем NameInfo1 = {Generation_Operation.BaseModul(a)}");
                                //Console.Clear();
                                if (u.NameInfo1 == Generation_Operation.BaseModul(a))
                                {
                                    Console.WriteLine($"Проиходит удаление всех строк с NameInfo1 = {Generation_Operation.BaseModul(a)}");
                                    db.Modul_Struct_Bases.Remove(u);
                                    Console.WriteLine("Выполняется сохранение изменений в базу");
                                    db.SaveChanges();
                                }
                            }
                            Console.WriteLine("Удаление записи, по имени темы выполнено");
                            Generation_Operation.InStart3(a);
                        }
                    }
                    break;
                case 4:
                    {
                        Generation_Operation.InStartString();
                        Generation_Operation.InStart3(int.Parse(Console.ReadLine()));
                    }
                    break;
                default:
                    Console.WriteLine("Введите число от 1 - 3 чтобы перейти к выбору действия");
                    //Start_Modul_Create();
                    //key = int.Parse(Console.ReadLine());
                    //switch(key)
                    //{
                    //    case 1:
                    //    case 2:
                    //    case 3:
                    //        {

                    //        }
                    break;
                    //}
                    //goto case 2;
                    //goto case 3;
            }
        }
        public void Adding_data_to_the_database(Modul_Struct Name)
        {
            
        }
        public void Method_Modul_Start()
        {
            Console.WriteLine("\n");
            if (Operation_Info_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить Info_Method, нажмите 1 ");
            }
            if (Operation_Create_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить Create_Method, нажмите 2 ");
            }
            if (Operation_Tasks_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить Tasks_Method, нажмите 3 ");
            }
            if (Operation_Examples_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить Examples_Method, нажмите 4 ");
            }
            Console.WriteLine("Чтобы перейти в выбору другого модуля, нажмите 5");
            Console.WriteLine("Чтобы перейти назад, нажмите 6");
        }
        public static object M1(string Modul_Struct)
        {
            //int y = (int)Modul_Struct + 1;

            return Modul_Struct;
        }
        public virtual void Method_Modul_Start_1(int a)
        {
            if (Operation_Info_Method_1 == null & Operation_Create_Method_1 == null & Operation_Tasks_Method_1 == null & Operation_Examples_Method_1 == null)
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
                Method_Modul_Start_1(a);
            }
            if (x == 2)
            {
                Console.Clear();
                Create_Method(a);
                Method_Modul_Start_1(a);
            }
            if (x == 3)
            {
                Console.Clear();
                Tasks_Method();
                Method_Modul_Start_1(a);
            }
            if (x == 4)
            {
                Console.Clear();
                Examples_Method(a);
                Method_Modul_Start_1(a);
            }
            if (x == 5)
            {
                Generation_Operation.EndInStart();
            }
            if (x == 6)
            {
                Generation_Operation.InStart3(a);
            }
            if (x > 6 || x < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-6, чтобы запустить необходимый метод");
                Method_Modul_Start_1(a);
            }
        }
        public void Info_Method()
        {
            Console.WriteLine($"{Structures_Create(Operation_Info_Method_1)}");
        }
        public virtual void Create_Method(int a)
        {
            if (Name_Create_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Create_Method_1}, нажмите 1 ");
            }
            if (Name_Create_Method_2 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Create_Method_2}, нажмите 2 ");
            }
            if (Name_Create_Method_3 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Create_Method_3}, нажмите 3 ");
            }
            if (Name_Create_Method_4 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Create_Method_4}, нажмите 4 ");
            }
            if (Name_Create_Method_5 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Create_Method_5}, нажмите 5 ");
            }
            if (Name_Create_Method_7 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Create_Method_7}, нажмите 6 ");
            }
            Console.WriteLine("Чтобы перейти в выбору другого метода модуля, нажмите 7");
            Console.WriteLine("Чтобы перейти в выбору другого модуля, нажмите 8");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Coddition_Create_1(a);
            }
            if (x == 2)
            {
                Coddition_Create_2(a);
            }
            if (x == 3)
            {
                Coddition_Create_3(a);
            }
            if (x == 4)
            {
                Coddition_Create_4(a);
            }
            if (x == 5)
            {
                Coddition_Create_5(a);
            }
            if (x == 6)
            {
                Coddition_Create_6(a);
                //var tuple = Coddition_Create_Type_Method_6();
                //Console.WriteLine(tuple.Item1);
                //Console.WriteLine(tuple.Item2);
            }
            if (x == 7)
            {
                Console.Clear();
                Method_Modul_Start_1(a);
            }
            if (x == 8)
            {
                Console.Clear();
                Generation_Operation.EndInStart();
            }

            if (x > 8 || x < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-7, чтобы запустить необходимый метод");
                Method_Modul_Start_1(a);
            }
        }
        public virtual void Coddition_Create_1(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Create_Method_1}");
            Console.WriteLine($"\nВывод результата работы метода: \n\"{Name_Create_Method_1}\" на консоль \n");
            Coddition_Create_Type_Method_1();
            Create_Method(a);
        }
        public virtual void Coddition_Create_Type_Method_1()
        {
            Console.WriteLine($"{Create_Create_Method_1}");
        }
        public virtual void Coddition_Create_2(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Create_Method_2}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Create_Method_2}\" на консоль \n");
            Coddition_Create_Type_Method_2();
            Create_Method(a);
        }
        public virtual void Coddition_Create_Type_Method_2()
        {
            Console.WriteLine($"{Create_Create_Method_2}");
        }
        public virtual void Coddition_Create_3(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Create_Method_3}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Create_Method_3}\" на консоль \n");
            Coddition_Create_Type_Method_3();
            Create_Method(a);
        }
        public virtual void Coddition_Create_Type_Method_3()
        {
            Console.WriteLine($"{Create_Create_Method_3}");
        }
        public virtual void Coddition_Create_4(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Create_Method_4}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Create_Method_4}\" на консоль \n");
            Coddition_Create_Type_Method_4();
            Create_Method(a);
        }
        public virtual void Coddition_Create_Type_Method_4()
        {
            Console.WriteLine($"{Create_Create_Method_4}");
        }
        public virtual void Coddition_Create_5(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Create_Method_5}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Create_Method_5}\" на консоль \n");
            Coddition_Create_Type_Method_5();
            Create_Method(a);
        }
        public virtual void Coddition_Create_Type_Method_5()
        {
            Console.WriteLine($"{Create_Create_Method_5}");
        }
        public virtual void Coddition_Create_6(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Create_Method_7}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Create_Method_7}\" на консоль \n");
            //if (Create_Create_Method_7_int != 0)
            //{
            Console.WriteLine(Create_Create_Method_7_string);
            var tuple = Coddition_Create_Type_Method_6();
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);             //разобраться
            //}
            Create_Method(a);
        }
        public virtual (string, int?, int) Coddition_Create_Type_Method_6()
        {
            int y = int.Parse(Console.ReadLine());
            Create_Create_Method_7_int2 = y;
            var (Create_Create_Method_7_string_1, Create_Create_Method_7_int_1, Create_Create_Method_7_int_2) =
                (Create_Create_Method_7_string, Create_Create_Method_7_int, Create_Create_Method_7_int2);
            return (Create_Create_Method_7_string_1, Create_Create_Method_7_int_1, Create_Create_Method_7_int_2);
        }

        public virtual void Tasks_Method()
        {
            Console.WriteLine($"{Operation_Tasks_Method_3}");
        }
        public virtual void Examples_Method(int a)
        {
            if (Name_Examples_Method_1 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Examples_Method_1}, нажмите 1 ");
            }
            if (Name_Examples_Method_2 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Examples_Method_2}, нажмите 2 ");
            }
            if (Name_Examples_Method_3 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Examples_Method_3}, нажмите 3 ");
            }
            if (Name_Examples_Method_4 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Examples_Method_4}, нажмите 4 ");
            }
            if (Name_Examples_Method_5 != null)
            {
                Console.WriteLine($"Чтобы запустить {Name_Examples_Method_5}, нажмите 5 ");
            }
            Console.WriteLine("Чтобы перейти в выбору другогой темы модуля, нажмите 6");
            Console.WriteLine("Чтобы перейти в выбору другого метода модуля, нажмите 7");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Coddition_Examples_1(a);
            }
            if (x == 2)
            {
                Coddition_Examples_2(a);
            }
            if (x == 3)
            {
                Coddition_Examples_3(a);
            }
            if (x == 4)
            {
                Coddition_Examples_4(a);
            }
            if (x == 5)
            {
                Coddition_Examples_5(a);
            }
            if (x == 6)
            {
                Console.Clear();
                Method_Modul_Start_1(a);
            }
            if (x == 7)
            {
                Console.Clear();
                Generation_Operation.EndInStart();
            }

            if (x > 7 || x < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-7, чтобы запустить необходимый метод");
                Method_Modul_Start_1(a);
            }
        }
        public virtual void Coddition_Examples_1(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Examples_Method_1}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Examples_Method_1}\" на консоль \n");
            Coddition_Examples_Type_Method_1();
            Examples_Method(a);
        }
        public virtual void Coddition_Examples_Type_Method_1()
        {
            Console.WriteLine($"{Create_Examples_Method_1}");
        }
        public virtual void Coddition_Examples_2(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Examples_Method_2}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Examples_Method_2}\" на консоль \n");
            Coddition_Examples_Type_Method_2();
            Examples_Method(a);
        }
        public virtual void Coddition_Examples_Type_Method_2()
        {
            Console.WriteLine($"{Create_Examples_Method_2}");
        }
        public virtual void Coddition_Examples_3(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Examples_Method_3}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Examples_Method_3}\" на консоль \n");
            Coddition_Examples_Type_Method_3();
            Examples_Method(a);
        }
        public virtual void Coddition_Examples_Type_Method_3()
        {
            Console.WriteLine($"{Create_Examples_Method_3}");
        }
        public virtual void Coddition_Examples_4(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Examples_Method_4}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Examples_Method_4}\" на консоль \n");
            Coddition_Examples_Type_Method_4();
            Examples_Method(a);
        }
        public virtual void Coddition_Examples_Type_Method_4()
        {
            Console.WriteLine($"{Create_Examples_Method_4}");
        }
        public virtual void Coddition_Examples_5(int a)
        {
            Console.Clear();
            Console.WriteLine($"{Operation_Examples_Method_5}");
            Console.WriteLine($"\nВывод результата работы метода:\n\"{Name_Examples_Method_5}\" на консоль \n");
            Coddition_Examples_Type_Method_5();
            Examples_Method(a);
        }
        public virtual void Coddition_Examples_Type_Method_5()
        {
            Console.WriteLine($"{Create_Examples_Method_5}");
        }
        public static string Structures_Create(string a) // метод, который переносит строку на следующию строчку дойдя до заданной длины строк,                                                      // записанной в переменную klenhth 
        {
            try
            {
                string result = "";
                if (a.Length < 70)
                {
                    Console.WriteLine(a);
                    //throw new Exception("Пустая строка");
                }
                else
                {
                    int klenhth = 94; // максимальный символ до которого будет доступен перенос строки 

                    do
                    {
                        for (int i = klenhth; i < a.Length; i--)
                        {
                            char[] charArr1 = { a[i] };  // идет поиск пробела в строке, создается массив типа char, который принимает элементы заданной строки (а)
                                                         // благодаря циклу for мы проходим по каждому элементу строки с идексами от klenhth = 94 до нулевого элемента

                            string str1 = new string(charArr1);  // создается строка, в которую записывается каждый элемент заданной в методе строки
                            string str2 = " ";                   // создается строка, с символом пробел, для поиске пробела в заданной строке
                            if (str1 == str2)                    // сравнивается каждый элемент заданной строки и строка с символом пробел
                            {
                                result = result + a.Substring(0, i) + "\n";   //пустой строке присваивается значение самой себя, плюс значение заданной строки, 
                                                                              //к которой применен метод Substring (0, i) и прибавляется символ переноса строки
                                                                              //Substing обрезает строку до ближайшего символа " " (пробел)
                                                                              //и записывает в переменную result плюс символ переноса строки
                                                                              //
                                                                              // первый случай срабатывания условия на 91 длинне 
                                                                              // в result записано от нуля до 91 строка 
                                                                              // а а записывается текст все что остается после 92 длины и из всей длины вычетается 92 ,
                                                                              // строка становиться длинной в 326-92 = 234 (a.Length) и начинается с 92 символа
                                                                              // цикл брейкнулся, но цикл while запускает for снова,
                                                                              // но строка уже обновилась и имеет 234 длину
                                                                              // дальше в новой строке имеющей длину 234 идет поиск пробела в диапазоне со 91+94=185 
                                                                              // со 185 символа и опускается вниз пока не найдет ближайший пробел
                                                                              // совпало на 84 длине теперь у нас в result уже две строки с переносом и символом /n
                                                                              // в начальную строку записалось 326-(91+84)-1 -1  = 149 
                                                                              // опять начинается поиск пробела длина строки для поиска 149
                                                                              //

                                a = a.Substring(i + 1);                       //заданной строке присваивается заданная строка с примененным метом Substring
                                                                              //метод обрезает строку на еденицу больше от символа,
                                                                              //по номеру которого найден ближайший пробел
                                                                              //от заданного значения по длине переноса строки klenhth
                                break;                                        //оператор break останавливает цикл
                            }
                            if (i == 1)                                       //редко выполнимое условие строка должна иметь слово в 94 символа без пробелов 
                                                                              //можно принебречь т к самое длинное слово на русском
                                                                              //превысокомногорассмотрительствующий - 35 символов
                                                                              //используется для обрезки с условием что длина обрезки klenhth будет равна 35
                                                                              //как длина самого длинного русского слова 
                                                                              //английское самое длинное слово Pneumonoultramicroscopicsilicovolcanoconiosis 
                                                                              //45 символов
                            {
                                result = result + a.Substring(0, klenhth) + "\n";
                                a = a.Substring(klenhth + 1);
                            }
                        }
                    }
                    while (a.Length > klenhth);
                    result = result + a;
                }
                return result;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Блок catch:\n {ex}");
            }
            throw new Exception("Строка не найдена");
        }
        public static string Code_Writer_Console(int x, int e)
        {
            string y = Generation_Operation.BaseModul(x);
            y = y.Replace("\n", " ");
            string Way_To_File = "C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2_17.06.2021\\ConsoleApp2\\For_Method_Code_Writer_Console\\" + y + "\\Модуль " + x + ", номер файла - " + e + ".txt";
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
                string a1 = Convert.ToString(DateTime.Today);
                string y = Generation_Operation.BaseModul(i);
                y = y.Replace("\n", " ");
                Directory.CreateDirectory($"C:\\Users\\Eduard.Karpov\\source\\repos\\1\\ConsoleApp2\\For_Method_Code_Writer_Console\\{y}");
                //создает 43 папки, в папке с приложением, по теме каждого модуля
                for (int j = 1; j <= 10; j++)
                {
                    File.Create($"C:\\Users\\Eduard.Karpov\\source\\repos\\1\\ConsoleApp2\\For_Method_Code_Writer_Console\\{y}\\Модуль {a1}, номер файла - {j}.txt");
                }
            }
        }
    }
}
