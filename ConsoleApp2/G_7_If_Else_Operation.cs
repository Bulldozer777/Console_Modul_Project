using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class G_7_If_Else_Operation : Modul_Struct
    {
        public static void IfElseInfo(int a)
        {
            Console.WriteLine("Mодуль 7");
            if (a == 7)
            {
                Modul_Struct Seven = new G_7_If_Else_Operation();   //нужно создавать объект класса наследника, после ключевого слова new
                operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                name_Create_Method_1 = "Операции сравнения";
                name_Create_Method_2 = "Логическое операции";
                operation_Create_Method_1 = Code_Writer_Console(a, 2);
                operation_Create_Method_2 = Code_Writer_Console(a, 3);            
                create_Create_Method_1 = Comparison_Operations();
                create_Create_Method_2 = Logical_Operations();
                Seven.Method_Modul_Start_1();
                Generation_Operation.EndInStart();
            }
        }
        public override void Create_Method()
        {
            Console.WriteLine($"Чтобы запустить {name_Create_Method_1} нажмите 1 ");
            Console.WriteLine($"Чтобы запустить {name_Create_Method_2} нажмите 2 ");
            Console.WriteLine("Чтобы перейти в выбору другогой темы модуля модуля нажмите 6");
            Console.WriteLine("Чтобы перейти в выбору другого модуля модуля нажмите 7");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                //Console.Clear();
                Console.WriteLine($"{operation_Create_Method_1}");
                Console.WriteLine($"Вывод результата работы метода \"{name_Create_Method_1}\" на консоль ");
                Console.WriteLine($"{create_Create_Method_1}");
                Create_Method();
            }
            if (x == 2)
            {
                //  Console.Clear();
                Console.WriteLine($"{operation_Create_Method_2}");
                Console.WriteLine($"Вывод результата работы метода \"{name_Create_Method_2}\" на консоль");
                Console.WriteLine($"{create_Create_Method_2}");
                Create_Method();
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
                Console.WriteLine("Вы ввели неверное число, введите число от 1-5, чтобы запустить необходимый метод");
                Method_Modul_Start_1();
            }
        }
            public static string Comparison_Operations()
        {
            //  == Сравнивает два операнда на равенство.
            //  Если они равны, то операция возвращает true, если не равны, то возвращается false:";
            int a = 10;
            int b = 4;
            bool c = a == b; // false
            string a2 = Convert.ToString($"bool c = a == b - {c}");
            //  != Сравнивает два операнда и возвращает true,
            //  если операнды не равны, и false, если они равны.";
            int a11 = 10;
            int b11 = 4;
            bool c11 = a11 != b11;    // true
            bool d11 = a11 != 10;     // false
            string a4 = Convert.ToString($"bool c11 = a11 != b11 - {c11}");
            string a5 = Convert.ToString($"bool d11 = a11 != 10 - {d11}");
            //  < Операция \"меньше чем\".Возвращает true,
            //  если первый операнд меньше второго, и false, если первый операнд больше второго: ";
            int a22 = 10;
            int b22 = 4;
            bool c22 = a22 < b22; // false
            string a7 = Convert.ToString($"bool c22 = a22 < b22 - {c22}");
            //  > Операция \"больше чем\".Сравнивает два операнда и возвращает true,
            //  если первый операнд больше второго, иначе возвращает false:";
            int a33 = 10;
            int b33 = 4;
            bool c33 = a33 > b33;     // true
            bool d33 = a33 > 25;    // false
            string a9 = Convert.ToString($"bool c33 = a33 > b33 - {c33}");
            string a10 = Convert.ToString($"bool d33 = a33 > 25 - {d33}");
            //  <= Операция \"меньше или равно\".Сравнивает два операнда и возвращает true,
            //  если первый операнд меньше или равен второму.Иначе возвращает false.";
            int a44 = 10;
            int b44 = 4;
            bool c44 = a44 <= b44;     // false
            bool d44 = a44 <= 25;    // true
            string a13 = Convert.ToString($"bool c44 = a44 <= b44 - {c44}");
            string a14 = Convert.ToString($"bool d44 = a44 <= 25 - {d44}");
            //  >= Операция \"больше или равно\".Сравнивает два операнда и возвращает true,
            //  если первый операнд больше или равен второму, иначе возвращается false:";
            int a55 = 10;
            int b55 = 4;
            bool c55 = a55 >= b55;     // true
            bool d55 = a55 >= 25;    // false
            string a16 = Convert.ToString($"bool c55 = a55 >= b55 - {c55}");
            string a17 = Convert.ToString($"bool d55 = a55 >= 25 - {d55}");
            string a18 = "Операции <, > <=, >= имеют больший приоритет, чем == и !=.";
            return  "\n" + a2   + "\n" + a4 + "\n" + a5  + "\n" + a7  + "\n" + a9 + "\n" + a10  + "\n" + a13 + "\n" + a14  + "\n" + a16 + "\n" + a17 + "\n" + a18 + "\n";
        }
        public static string Logical_Operations()
        {
            //| Операция логического сложения или логическое ИЛИ.
            //Возвращает true, если хотя бы один из операндов возвращает true.";
            bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
            string a2 = Convert.ToString($"bool x1 = (5 > 6) | (4 < 6) - { x1}");
            string a3 = Convert.ToString($"bool x2 = (5 > 6) | (4 > 6) - { x2}");
            //& Операция логического умножения или логическое И.
            //Возвращает true, если оба операнда одновременно равны true.";
            bool x11 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool x22 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
            string a5 = Convert.ToString($"bool x11 = (5 > 6) & (4 < 6) - {x11}");
            string a6 = Convert.ToString($"bool x22 = (5 < 6) & (4 < 6) - {x22}");
            //|| Операция логического сложения.
            //Возвращает true, если хотя бы один из операндов возвращает true.";
            bool x33 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x44 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
            string a9 = Convert.ToString($"bool x33 = (5 > 6) || (4 < 6) - {x33}");
            string a10 = Convert.ToString($"bool x44 = (5 > 6) || (4 > 6) - {x44}");
            //&& Операция логического умножения.
            //Возвращает true, если оба операнда одновременно равны true.";
            bool x55 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool x66 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
            string a12 = Convert.ToString($"bool x55 = (5 > 6) && (4 < 6) - {x55}");
            string a13 = Convert.ToString($"bool x66 = (5 < 6) && (4 < 6) - {x66}");
            //! Операция логического отрицания.
            //Производится над одним операндом и возвращает true, если операнд равен false.
            //Если операнд равен true, то операция возвращает false:";
            bool a = true;
            bool b77 = !a;    // false
            string a15 = Convert.ToString($"bool b77 = !a - b77");          
            //^ Операция исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false";
            bool x88 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x99 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
            string a17 = Convert.ToString($"bool x88 = (5 > 6) ^ (4 < 6) - {x88}");
            string a18 = Convert.ToString($"bool x99 = (50 > 6) ^ (4 / 2 < 3) - {x99}");
            return  "\n" + a2 + "\n" + a3  + "\n" + a5 + "\n" + a6  + "\n" + a9 + "\n" + a10  + "\n" + a12 + "\n" + a13  + "\n" + a15 + "\n" + a17 + "\n" + a18 + "\n";
        }
        public static void IfElseGeneral(int x)
        {
            if (x == 1)
            {
                Console.WriteLine("Отдельный набор операций представляет условные выражения. Такие операции возвращают логическое значение, то есть значение типа\n bool: true, если выражение истинно, и false, если выражение ложно. К подобным операциям относятся операции сравнения и логические\n операции.");
                //  Console.WriteLine("Общая информация, нажмите 1");
          //      IfElseStart();
                int i = int.Parse(Console.ReadLine());
                GetEnd(i);
            }
        }
        public static void GetEnd(int x)
        {
        //    IfElseStart();
            if (x == 4)
            {
              //  Program.EndInStart();
            }
        }
        public static void IfElseTack(int x)
        {
            if (x == 3)
            {
            //    IfElseStart();
                int i = int.Parse(Console.ReadLine());
                GetEnd(i);
            }
        }
        public override void Examples_Method()
        {
            Console.WriteLine(Calculating_The_Volume_Of_A_Box()); 
        }
        public static string Calculating_The_Volume_Of_A_Box() //стринговый вариант метода
        {
            Console.WriteLine("Метод Calculating_The_Volume_Of_A_Box()");
            Console.WriteLine("Считает чистый объем короба под сабвуфер");
            string a1 = "";
            string a2 = "";
            string a3 = "";
            string a4 = "";
            int a;
            Console.WriteLine("Введите длину (mm):");
            a = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.WriteLine("Введите высоту (mm):");
            c = Convert.ToInt32(Console.ReadLine());

            int b;
            Console.WriteLine("Введите ширину (mm):");
            b = Convert.ToInt32(Console.ReadLine());

            int e;
            Console.WriteLine("Введите толщину фанеры (mm):");
            e = Convert.ToInt32(Console.ReadLine());

            int o;
            Console.WriteLine("Введите диаметр трубы (mm):");
            o = Convert.ToInt32(Console.ReadLine());

            int l;
            Console.WriteLine("Введите длину трубы (mm):");
            l = Convert.ToInt32(Console.ReadLine());
            string y;
            Console.WriteLine("Наличие двойного лба у короба (да или нет):");
            y = Convert.ToString(Console.ReadLine());
            if (y != "да" & y != "нет")
            {

                Console.WriteLine("Наличие двойного лба у короба (да или нет):");
                y = Convert.ToString(Console.ReadLine());
            }
            if (y == "да")
            {
                int d = a * b * c;
                int r = ((a - e * 2) * (b - e * 2) * (c - e * 2)) - ((b - e * 2) * (a - e * 2) * e);
                var k = r - (3.14 * o * o * 0.25 * l);
                var u = Math.Floor(d * 0.0001) * 0.01; // = 25.01
                var p = Math.Floor(r * 0.0001) * 0.01; // = 25.01
                var m = Math.Floor(k * 0.0001) * 0.01; // = 25.01
                var s = k - 10000000;
                var z = Math.Floor(s * 0.0001) * 0.01; // = 25.01
                a1 = Convert.ToString("Объем равен " + u);
                a2 = Convert.ToString("Объем c учетом толщины фанеры равен " + p);
                a3 = Convert.ToString("Объем c учетом толщины фанеры равен и вытеснетия объема трубы " + m);
                a4 = Convert.ToString("Чистый объем короба с динамиком внутри, динамик Т15, 10 литров " + z);
            }
            else if (y == "нет")
            {
                int d = a * b * c;
                int r = ((a - e * 2) * (b - e * 2) * (c - e * 2));
                var k = r - (3.14 * o * o * 0.25 * l);
                var u = Math.Floor(d * 0.0001) * 0.01; // = 25.01
                var p = Math.Floor(r * 0.0001) * 0.01; // = 25.01
                var m = Math.Floor(k * 0.0001) * 0.01; // = 25.01
                var s = k - 10000000;
                var z = Math.Floor(s * 0.0001) * 0.01; // = 25.01
                a1 = Convert.ToString("Объем равен " + u);
                a2 = Convert.ToString("Объем c учетом толщины фанеры равен " + p);
                a3 = Convert.ToString("Объем c учетом толщины фанеры равен и вытеснетия объема трубы " + m);
                a4 = Convert.ToString("Чистый объем короба с динамиком внутри, динамик Т15, 10 литров " + z);
            }
            else
            {
                Console.WriteLine("Введите верный ответ");
            }
            return "\n" + a1 + "\n" + a2 + "\n" + a3 + "\n" + a4;
        }
    }
}
