using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class F_6_Create_Base_Type_Data : Modul_Struct
    {
        public static void TypeCreate(int i)
        {
            Console.WriteLine("Mодуль 6");
            if (i == 6)
            {
                Modul_Struct Six = new F_6_Create_Base_Type_Data();   //нужно создавать объект класса наследника, после ключевого слова new
                name_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(i, 3));
                operation_Create_Method_1 = Code_Writer_Console(i, 1);          
                create_Create_Method_1 = Check();
                operation_Info_Method_1 = Code_Writer_Console(i, 2);
                operation_Tasks_Method_3 = Code_Writer_Console(i, 5);
                operation_Tasks_Method_4 = Code_Writer_Console(i, 6);
                operation_Examples_Method_4 = Code_Writer_Console(i, 4) + "\n" + "Результат работы тренировочного метода" + Examples(); 
                Six.Method_Modul_Start_1();
                Generation_Operation.EndInStart();
            }
        }
        public override void Create_Method()  //работает переопределение метода
        {
            Console.WriteLine($"{operation_Create_Method_1}");
            Console.WriteLine($"{create_Create_Method_1}");
        }       
        public static void Check_1()
        {
            byte a = 4;
            byte b = (byte)(a + 70);            
            Console.WriteLine(b);
            try
            {
                int k = 33;
                int y = 600;
                byte l = checked((byte)(k + y));
                Console.WriteLine(l);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Недоступный диапазон");
            }
            //Ключевое слово checked проверяет не теряется ли диапазон, если теряется то выводит ошибку
            short b1 = (short)(a + 70);//byte/short/int - при произведении операции используется тип int
                                       //изначально в byte переменной при созданиии 1 байт а при операции типа int там уже 4 байта 
            Console.WriteLine(b1);                                       
        }
        public override void Tasks_Method()
        {
            Console.WriteLine($"{operation_Tasks_Method_3}"  );
            Console.WriteLine("Введите 1, чтобы узнать ответы на вопросы");
            int y = int.Parse(Console.ReadLine());
            if (y== 1)
            {
                Console.WriteLine($"{operation_Tasks_Method_4}");
            }
            else
            {        
                Console.WriteLine("Вы ввели не 1");
                Tasks_Method();
            }
            Console.WriteLine();
        }
        public static string Check()
        {
            byte a = 4;
            byte b = (byte)(a + 70); //byte/short/int - при произведении операции используется тип int
                                     //изначально в byte переменной при созданиии 1 байт а при операции типа int там уже 4 байта //называется расширяющее перобразование
            string a1 = Convert.ToString(b);            
            string a11 = "";
            string a12 = "";
            try
            {
                int k = 33;
                int y = 600;
                byte l = checked((byte)(k + y));
                a11 = Convert.ToString(l);
            }
            catch (OverflowException)
            {
               a12 = "Недоступный диапазон";
            }
            //Ключевое слово checked проверяет не теряется ли диапазон, если теряется то выводит ошибку");
            short b1 = (short)(a + 70);//byte/short/int - при произведении операции используется тип int
                                       //изначально в byte переменной при созданиии 1 байт а при операции типа int там уже 4 байта 
           string a2 = Convert.ToString(b1);
            return   a1 + "\n" + a2 + "\n" + a11 + "\n" + a12 + "\n";
        }
        public static string Examples()
        {
            byte a = 89;
            byte b = (byte)(a + 70); //byte/short/int - при произведении операции используется тип int
                                     //изначально в byte переменной при созданиии 1 байт а при операции типа int там уже 4 байта //называется расширяющее перобразование
            string a1 = Convert.ToString(b);
            string a11 = "";
            string a12 = "";
            try
            {
                int k = 33;
                int y = 6000;
                byte l = checked((byte)(k + y));
                a11 = Convert.ToString(l);
            }
            catch (OverflowException)
            {
                a12 = "Недоступный диапазон";
            }
            //Ключевое слово checked проверяет не теряется ли диапазон, если теряется то выводит ошибку");
            short b1 = (short)(a + 70);//byte/short/int - при произведении операции используется тип int
                                       //изначально в byte переменной при созданиии 1 байт а при операции типа int там уже 4 байта 
            string a2 = Convert.ToString(b1);
            return "\n" + a1 + "\n" + a2 + "\n" + a11 + "\n" + a12 + "\n";
        }
        public static string Task(int h, Modul_Struct Six)
        {
            if (h == 1 )
            {
                return Code_Writer_Console(6, 5);
            }
            else
            {
                Six.Method_Modul_Start_1();
                return "Вы ввели неверное число";
                
            }             
        }
    }

}

