using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;

namespace Training_Csharp
{
    struct Mass    //структура
    {
        public int mass;

        // public int mass;

        //public
        public Mass(int a)  //конструктор 
        {
            mass = a;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{mass}");
        }
    }
    struct User    //структура
    {
        public string name;
        public int age;
        // public int mass;

        //public
        public User(string n, int a)  //конструктор 
        {
            name = n; age = a;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"name = {name} age = {age}");
        }
    }
    struct Subwoofer
    {
        public string name_subwoofer;
        public int price;
        public int caliber;
        public int Fs;
        public double Qts;
        public int Vas;
        public int speaker_weight;
        public int coil_size;

        public Subwoofer(string n, int a, int a1, int a2, double a3, int a4, int a5, int a6)  //конструктор 
        {
            name_subwoofer = n; price = a; caliber = a1; Fs = a2; Qts = a3; Vas = a4; speaker_weight = a5; coil_size = a6;
        }
        public void Display()
        {
            name_subwoofer = name_subwoofer.ToUpper();
            Console.WriteLine($"\nнаименование сабвуфера = {name_subwoofer}\n \nцена = {price}р. \nкалибр = {caliber}\nрезонансная частота Fs  = {Fs}Hz \nдобротность Qts  = {Qts}\nэквивалентный объем динамика Vas = {Vas}литров\nвес динамика  = {speaker_weight}кг \nразмер катушки = {coil_size}дюйма ");
        }
    }
    class Q_17_Structures : Modul_Struct
    {
        public static string Structures_Create(string a) // метод, который переносит строку на следующию строчку дойдя до заданной длины строк,
                                                       // записанной в переменную klenhth 
        {
            string result = "";
            if (a.Length < 70)
            {
                Console.WriteLine(a);
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
        public static string String_Create_CompilationMethanit(string a)
        {
            string result = "";
            for (int i = 12; i < a.Length; i = i + 1)
            {
                char[] charArr1 = { a[i] };
                string str1 = new string(charArr1);
                string str2 = "}";
                string str3 = "{";
                string str4 = ";";
                string str5 = " ";
                if (str1 == str3)
                {
                    {

                      // this.a[i] = "\n" + a[i] + "\n";
                        result = result + a.Substring(0, i-1) + "\n";
                     //   result = result + a.Replace(" { " , "\n{\n");
                       a =  a.Substring(i);
                    }
                }
                else if (str1 == str2)
                {
                    {
                        result = result + a.Substring(0, i+1)+ "\n";
                        a = a.Substring(i + 1);
                    }
                }
                else if (str1 == str4)
                {
                    {
                        result = result + a.Substring(0, i+1) + "\n";
                        a = a.Substring(i + 1);
                    }
                }
                else if (str1 == str5)
                {
                    {
                        result = result + a.Substring(0, i) + "\n";
                        a = a.Substring(i + 1);
                    }
                }
            }
            result = result + a;
            return result;
        }
        public static void Method2()
        {
            string a = "Поскольку у всех пользователей возвраст больше 20, то переменная result1 будет равна true. В то же время не у всех пользователей имя начинаяется с буквы T, поэтому вторая переменная result2 будет равна false.";
            Console.WriteLine(a.Substring(0,10));
        }
        public static void Structures_Info(int a)
        {
            if (a == 17)
            {
                Modul_Struct seventeen = new Q_17_Structures();
                Modul_Struct_Start_With_DB(a, seventeen,                 // использовать именнованные параметры, пример (x:2, y:3)
                    Structures_Create(Code_Writer_Console(a, 1)) + "\n"
                    + Code_Writer_Console(a, 2) + Code_Writer_Console(a, 3),
                    "Структура User",
                    OperationCreate1_p: Code_Writer_Console(a, 4),
                    NameCreate2_p: "Вывод структуры через цикл foreach",
                    OperationCreate2_p: Code_Writer_Console(a, 5),
                    NameExamples1_p: "Структура - характеристики сабвуфера",
                    NameCreate3_p: "метод 4",
                    OperationExamples1_p: Code_Writer_Console(a, 6)
                    );
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Console.WriteLine("Вывод метода, который описывает логику структуры User");
            Struct_User();
            Console.WriteLine("\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Console.WriteLine("Вывод метода, который выводит структуру через цикл foreach");
            Struct_User_Mass();
            Console.WriteLine("\n");
        }
        public override void Coddition_Create_Type_Method_3()
        {
            //Console.WriteLine("Вывод метода, который выводит структуру через цикл foreach");         
        }
        public override void Coddition_Examples_Type_Method_1()
        {
            Subwoofer[] speaker = new Subwoofer[2];
            speaker[0] = new Subwoofer("Pride T15 v3", 30000, 15, 29, 0.45, 100, 30, 3);
            speaker[1] = new Subwoofer("Pride ST15 v3", 54000, 15, 28, 0.35, 121, 45, 4);
            foreach (Subwoofer subwoofer in speaker)
            {
                subwoofer.Display();
            }
        }
        public static void Struct_User()
        {
            User tom; // переменная типа user
            tom.name = "Tom";
            tom.age = 23;
            int d = tom.age;
            tom.DisplayInfo();
        }
        public static void Struct_User_Mass()
        {
            User[] users = new User[2];
            users[0] = new User("Bob", 20); // обращение к конструктору 
                                            // users[0].age = 20;
            users[1].name = "Sam";
            users[1].age = 25;
            foreach (User user in users)
            {
                user.DisplayInfo();
            }
            User rot = new User("Bob", 23);// обращение к конструктору
            rot.DisplayInfo();
        }
        public static void Mas_value(int a)
        {
            int[] p = new int[46];
            for (int i = 0; i < 46; i++)
            {
                p[i] = a;
            }
            foreach (int i in p)
            {
                Console.WriteLine(i);
            }
        }

        public static void Mass_Value_Display()
        {
            //int[] p = new int[o];
            //for (int i = 0; i < o; i++)
            //{
            //    p[i] = a;
            //    Mas_value(a);
            //    foreach (int i in p)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
        public static void Checking_for_spaces(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                char[] charArr1 = { a[i] };
                string str1 = new string(charArr1);
                string str2 = " ";
                if (str1 == str2)
                {
                  
                }            
            }
            Console.WriteLine(a);
        }
        public static void Value_Display()
        {
            string text = "И поэтому все так произошло";
            if (text.Length > 10)
            {
                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in words)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void Method1()   // перенос строки по заданным символам с приминением Contains - метода пространства имен System.Linq 
        {                                // Contains - метод для поиска в строке хотя бы одного элемента соотвествующего заданному условию
                                         // Contains - возвращает true или false при нахождении хотя бы одного элемента соотвествующего условию


            string sourceString = "Есть текст нужно чтобы. через каждые 300 символов искал запятую, точку, пробел и т.д (Искал не после 300 символов а именно в этом отрезке 0 - 300 или например 300 - 600) и после этого символа(запятой, точки, пробела и т.д.) делал перенос строки и так далее. Я хочу вывести это через Label, я знаю что есть вариант с Textbox но он мне не подходит.";
            int length = 50;
            char[] charsForEOL = { '.', ',', ' ' };
            string resultString = "";
            do
            {
                for (int i = length; i >= 1; i--)
                {
                    if (charsForEOL.Contains(sourceString[i]))
                    {
                        resultString += sourceString.Substring(0, i) + "\n";
                        sourceString = sourceString.Substring(i + 1);
                        break;
                    }
                    if (i == 1)
                    {
                        resultString += sourceString.Substring(0, length) + "\n";
                        sourceString = sourceString.Substring(length + 1);
                    }
                }
            } while (sourceString.Length > length);

            resultString += sourceString;
            Console.WriteLine(resultString);
        }
    }


}

