using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class L_12_Method_Parameters : Modul_Struct
    {
        public static void Method_Parameters(int a)
        {
            if (a == 12)
            {
                Modul_Struct Twelve = new L_12_Method_Parameters();   //нужно создавать объект класса наследника, после ключевого слова new
                operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                name_Create_Method_1 = "Передача параметров по значению и по ссылке";
                operation_Create_Method_1 = Code_Writer_Console(a, 2);
                name_Create_Method_2 = "Выходные параметры. Модификатор out ";
                operation_Create_Method_2 = Code_Writer_Console(a, 3);
                name_Create_Method_3 = "Необязательные параметры";
                operation_Create_Method_3 = Code_Writer_Console(a, 4);
                name_Create_Method_4 = "Именованные параметры";
                operation_Create_Method_4 = Code_Writer_Console(a, 5);
                name_Examples_Method_1 = "Расчет короба под сабвуфер";
                operation_Examples_Method_1 = Code_Writer_Console(a, 6);
                Twelve.Method_Modul_Start_1();
                Console.WriteLine("Именованные параметры");
                Generation_Operation.EndInStart();
            }
        }
        public override void Coddition_Create_Type_Method_1()
        {
            int z = 5;
            int d = 6;
            Console.WriteLine($"Intermal value z = {z}"); //5
            AdditionVal(z, d); //
                               //Метод создает копию переменной z в памяти и работает с копией ,
                               //переменная z после отработки метода не меняет свое значение
            Console.WriteLine($"AdditionVal z = {z}"); //5
            AdditionRef(ref z, d); 
            //Метод работает с самой переменной z и переменная z после отработки метода меняет свое значение  ,
            //ref передача значения по ссылке,
            //ключевое слово ref ставиться в параметрах метода и при работе(выводе) метода в месте объявления параметров
            Console.WriteLine($"AdditionRef z = {z}"); //11 переменной z передается значение переменной x
                                                       //т к эти переменные 
                                                       //используют одну и ту же область в памяти и
                                                       //если переменная х стал равен 11,
                                                       //то переменная z тоже становиться равена 11
            Console.WriteLine("Выполним AdditionRef 10 раз"); //чтобы увидеть как z меняет значение
            for (int i = 0; i < 10; i++)
            {
                AdditionRef(ref z, d);
                Console.WriteLine($"\nAdditionRef z = {z}"); 
            }           
        }
        public override void Coddition_Create_Type_Method_2()
        {
            int area;
            int perimeter;
            GetData(12, 130, out area, out perimeter);
            //выходные параметры заданы не return, а ключевым словом out,
            //созданы пустые переменные такие же как и в методе и заполены результатом выполнения метода   
            Console.WriteLine($"Area - {area}");
            Console.WriteLine($"Perimeter - {perimeter}");
            Console.WriteLine("Необязательные параметры");
        }
        public override void Coddition_Create_Type_Method_3()
        {
            //Необязательные параметры
        
            int d1 = Optional(1, 2, 3, 4);
            int d2 = Optional(1, 2, 3);
            int d3 = Optional(1, 2);
            // параметры заданы в методе по умолчанию, так что их можно не заполнять и они заполняться теми,
            // что указаны в методы при его объявлении
            Console.WriteLine(d1); //10
            Console.WriteLine(d2); //13
            Console.WriteLine(d3); //15
        }
        public override void Coddition_Create_Type_Method_4()
        {
            // Именованные параметры x:2 , происходит указание какому именно параметру мы присваиваем значение,
            // могут идти не по порядку, можем  изменить порядок передачи значений параметрам,
            // по умолчанию они(параметры) передаются по позиции
            int d1 = Optional(s: 1, y: 2, z: 3, x: 4);
            int d2 = Optional(1, 2, 3);
            int d3 = Optional(1, 2);
            Console.WriteLine(d1); 
            Console.WriteLine(d2); 
            Console.WriteLine(d3); 
        }
        public override void Coddition_Examples_Type_Method_1()
        {
            string amount_total;
            string amount_without_plywood_thickness;
            string amount_without_plywood_and_pipe;
            string pure_amount;
            Calculating_The_Volume_Of_A_Box_1(out amount_total, out amount_without_plywood_thickness, out amount_without_plywood_and_pipe, out pure_amount);
            Console.WriteLine($"Объем общий - {amount_total}");
            Console.WriteLine($"Объем без учета толщины фанеры равен - {amount_without_plywood_thickness}");
            Console.WriteLine($"Объем c учетом толщины фанеры равен и вытеснетия объема трубы - {amount_without_plywood_and_pipe}");
            Console.WriteLine($"Чистый объем короба с динамиком внутри, динамик Т15, 10 литров - {pure_amount}\n");
        }
        public static void AdditionRef(ref int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionRef x = {x}");              
        }
        public static void AdditionVal(int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionVal x = {x}");
        }
        public static void GetData(int width, int height, out int area, out int perimeter)
        {
            perimeter = (width + height) * 2;
            area = width * height;
        }
        public static int Optional(int x, int y,  int z = 5,  int s = 7)
        {
            return x + y + z + s;

        }
        public static void Calculating_The_Volume_Of_A_Box_1(out string a1, out string a2, out string a3, out  string a4) 
        {
            Console.WriteLine("Метод Calculating_The_Volume_Of_A_Box()");
            Console.WriteLine("Считает чистый объем короба под сабвуфер\n");
            a1 = "";
            a2 = "";
            a3 = "";
            a4 = "";
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
                int u;
                int p;
                int z;
                int m;
                Box_volume(d, r,k, out u, out p, out z, out m);
                a1 = Convert.ToString(u);
                a2 = Convert.ToString(p);
                a3 = Convert.ToString(m);
                a4 = Convert.ToString(z);
            }
            else if (y == "нет")
            {
                int d = a * b * c;
                int r = ((a - e * 2) * (b - e * 2) * (c - e * 2));
                var k = r - (3.14 * o * o * 0.25 * l);
                int u;
                int p;
                int z;
                int m;
                Box_volume(d, r, k, out u, out p, out z, out m);
                a1 = Convert.ToString(u);
                a2 = Convert.ToString(p);
                a3 = Convert.ToString(m);
                a4 = Convert.ToString(z);
            }
            else
            {
                Console.WriteLine("Введите верный ответ");
            }
        }
        public static void Box_volume(int d , int r , double k, out int u, out int p, out int z, out int m)
        {
             u = Convert.ToInt32(Math.Floor(d * 0.0001) * 0.01); // = 25.01
             p = Convert.ToInt32(Math.Floor(r * 0.0001) * 0.01); // = 25.01
             m = Convert.ToInt32(Math.Floor(k * 0.0001) * 0.01); // = 25.01
            var s = k - 10000000;
             z = Convert.ToInt32(Math.Floor(s * 0.0001) * 0.01); // = 25.01
        }
    }
}
