using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class E_5_Bitwise_Operations : Modul_Struct
    {
        public static void E_5_Bitwise_Operations_Info(int a) //Класс E_5_Bitwise_Operations это 5 Модуль - тема модуля "Поразрядные операции"
                                                              //Класс E_5_Bitwise_Operations наследуется от класса Modul_Struct
                                                              //т е имеет все методы и доступ к полям Modul_Struct, т к поля класса с модификатором public.
                                                              //Далее в основном методе класса E_5_Bitwise_Operations, создается объект класса Modul_Struct,
                                                              //без создания объекта класса нельзя работать с его методом Method_Modul_Start_1(),
                                                              //который запускает основное меню любого модуля наследуемого от Modul_Struct.
                                                              //Внутри метода Method_Modul_Start_1(), есть метод Create_Method(),
                                                              //в данном методе идет описание логики дочернего меню, которое служит для навигации по подтемам модуля.
                                                              //Далее создается объект класса Modul_Struct, создание объкта необходимо т к 
                                                              //Метод Create_Method()с модификатором virtual - это виртуальный метод, его можно переопределить,
                                                              //Возможность для переопределения метода нужна для изменения логики метода,
                                                              //Логика метода изменена в Модуле 6 класс F_6_Create_Base_Type_Data "Преобразования базовых типов данных"
                                                              //Там не так много методов, чтобы делать подтемы и подменю и поэтому, метод для навигации изменен
                                                              //Статический метод не может быть виртуальным, если бы метод Create_Method() был статическим,
                                                              //то тогда метод Method_Modul_Start_1(), служащий для запуска основной логики и меню
                                                              //тоже можно было бы сделать статическим, т к Create_Method() находится внутри Method_Modul_Start_1().
                                                              //Поэтому происходит создание объекта класса Modul_Struct Five = new Modul_Struct();
                                                              //Если бы все методы класса Modul_Struct были бы статическими,
                                                              //то создание объекта класса Modul_Struct было бы не нужно.
                                                              //Дальше заполняются поля класса Modul_Struct,
                                                              //Поле name_Create_Method_n - служит для заполнения названия методов модуля по темам
                                                              //где n - номер позиции в дочернем меню модуля, логика, где используется поле name_Create_Method_n
                                                              //описана в методе Create_Method(), который запускается в  Method_Modul_Start_1()
                                                              //Поле operation_Create_Method_n - служит для заполнения кода,
                                                              //который используется для вывода на консоль, где n - номер позиции в дочернем меню модуля
                                                              //Значение поля name_Create_Method_n обычно равно значению метода Code_Writer_Console(a, 1),
                                                              //который берет из папки приложения по имени модуля и номеру файла текстовый документ,
                                                              //эта информация заполняется в параметрах метода, при его вызове.
                                                              //Метод Code_Writer_Console(a, 1) выводит на консоль содержимое текстового документа
                                                              //Поле create_Create_Method_n - служит для заполнения значения результата выполнения метода,
                                                              //используемого в классе определенного модуля
                                                              //т е для наглядности выводится код основного метода модуля
                                                              //и сразу выводится результат выполнения кода консоль.
                                                              //Далее в методе Method_Modul_Start_1(), происходит работа и
                                                              //распределение всех данных согласно описанной в методе логике.
                                                              //Для заполнения полей в классе Modul_Struct не опредлен конструктор,
                                                              //т к пока удобнее и нагляднее заполнять поля класса сразу, чем вызывать конструктор 
                                                              //На примере 5 Модуля.
                                                              //1. Название метода: name_Create_Method_1 = "Логическое умножение";
                                                              //2. Код Метода: operation_Create_Method_1 = Code_Writer_Console(a, 1);
                                                              //3. Результат выполнения метода create_Create_Method_n = E_5_Bitwise_Operations_Logic_Multiplication();


        {
            if (a == 5)
            {
                Modul_Struct Five = new Modul_Struct();
                name_Create_Method_1 = "Логическое умножение";
                name_Create_Method_2 = "Логическое сложение";
                name_Create_Method_3 = "Операция исключающего \"или\" или XOR";
                name_Create_Method_4 = "Логическое отрицание или инверсия";
                name_Create_Method_5 = "Операции сдвига";
                operation_Create_Method_1 = Code_Writer_Console(a, 1);
                operation_Create_Method_2 = Code_Writer_Console(a, 2);
                operation_Create_Method_3 = Code_Writer_Console(a, 3);
                operation_Create_Method_4 = Code_Writer_Console(a, 4);
                operation_Create_Method_5 = Code_Writer_Console(a, 5);
                create_Create_Method_1 = E_5_Bitwise_Operations_Logic_Multiplication();
                create_Create_Method_2 = E_5_Bitwise_Operations_Create_Logic_Addition();
                create_Create_Method_3 = E_5_Bitwise_Operations_Create_Logic_OR();
                create_Create_Method_4 = E_5_Bitwise_Operations_Create_Logic_Inversion();
                create_Create_Method_5 = E_5_Bitwise_Operations_Create_Logic_The_Shift();
                operation_Tasks_Method_3 = "using System;\nnamespace helloapp\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\nConsole.WriteLine(\"Привет мир, задача!\");Console.WriteLine(\"решаем и тренируемся!\");\n}\n}\n}";
                operation_Examples_Method_4 = "546";
                Five.Method_Modul_Start_1(); 

            }
            Generation_Operation.EndInStart();
        }
        public static string E_5_Bitwise_Operations_Logic_Multiplication()
        {
          //  string a1 =
            int x1 = 2;    // 010 двоичное представление
            int y1 = 5; //101 
                        //000 логическое умножение, в итоге 0
           string a5 = "Логическое умножение";
            string a1 = Convert.ToString(x1 & y1);
            int x2 = 4;    //100
            int y2 = 5;      //101
            string a2 = Convert.ToString(x2 & y2); //100- в двоичной т е в консоле число 4 
            int x3 = 0b100; //запись числа в бинарном (двоичном) формате 
            //x3 = 4
            int x5 = 0b101; // запись числа в бинарном формате - число 5
            string a3 = Convert.ToString(x3 & x5); //результат 4
           // string a4 = a1 + " " a2 + a3;
            return a5 + "\n" + a1 + "\n" + a2 + "\n" + a3 + "\n";
        }
        public static string E_5_Bitwise_Operations_Create_Logic_Addition()
        {
            string a1 = "Логическое сложение";                
            int x1 = 2;    // 010 двоичное представление
            int y1 = 5; //101 
                        //111 логическое сложение, в итоге - 7
            string a2 = Convert.ToString(x1 | y1);
            int x2 = 4;    //100
            int y2 = 5;      //101
            string a3 = Convert.ToString(x2 | y2); //101- в двоичной т е в консоле число 5
            int x3 = 0b100; //запись числа в бинарном (двоичном) формате 
            //x3 = 4
            int x5 = 0b101; // запись числа в бинарном формате - число 5
            string a4 = Convert.ToString(x3 | x5); //результат 5 
            return a1 + "\n" + a2 + "\n" + a3 + "\n" + a4 + "\n";
        }
        public static string E_5_Bitwise_Operations_Create_Logic_OR()
        {
            string a1 = "Операция исключающего \"или\" или XOR";
            int x3 = 45;   //0101101
            int key = 102; //1100110
            int encrypt = x3 ^ key; // 1001011 - 75 (сравниваются 2 числа и если числа разные то возвращает 1 )
            string a2 = Convert.ToString(encrypt);
            int decrypt = encrypt ^ key; //можно шифровать
            string a3 = Convert.ToString(decrypt);
            return a1 + "\n" + a2 + "\n" + a3 + "\n";
        }
        public static string E_5_Bitwise_Operations_Create_Logic_Inversion()
        {
            string a1 = Convert.ToString("Логическое отрицание или инверсия"); //операция над 1 операндом
            int x = 9; //1001 при инверсии 0110 - переменная инт содержит не 4 бита а 32 и в итоге -10
            string a2 = Convert.ToString(~x); //-10
            string a3 = Convert.ToString(Convert.ToString(-10,2)); //данное число интепритируется как -10
            return a1 + "\n" + a2 + "\n" + a3 + "\n";
        }
        public static string E_5_Bitwise_Operations_Create_Logic_The_Shift()
        {
            string a1 = Convert.ToString("Операции сдвига");
            int x = 4;//100 двоичное
            string a2 = Convert.ToString(x << 1); //1000 - 8
            string a3 = Convert.ToString(x << 2); //10000-16
            string a4 = Convert.ToString(x >> 1); //10 - 2
            string a5 = Convert.ToString(x >> 2); //1 -1 
            return a1 + "\n" + a2 + "\n" + a3 + "\n" + a4 + "\n" + a5 + "\n";
        }
    }
}
