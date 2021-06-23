using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class S_19_Exceptions : Modul_Struct
    {
        public static void ExceptionsInfo(int a)
        {
            if (a == 19)
            {
                Modul_Struct nineteen = new S_19_Exceptions();
                Modul_Struct_Start_With_DB(a, nineteen,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Structures_Create(Code_Writer_Console(a, 1)),
                    NameCreate1_p: "try ... catch ... finally \nОбщий тип исключений Exception",
                    OperationCreate1_p: Code_Writer_Console(a, 3),
                    NameCreate2_p: "try ... catch ... finally \nТипы исключений",
                    OperationCreate2_p: Code_Writer_Console(a, 2),
                    NameCreate3_p: "Ввод с консоли до 6 символов, иначе генерируется исключение",
                    OperationCreate3_p: Code_Writer_Console(a, 4),
                    //NameCreate4_p: "Кортеж string и int",
                    //OperationCreate4_p: Code_Writer_Console(a, 6),
                    NameExamples1_p: "",
                    OperationExamples1_p: Code_Writer_Console(a, 6)
                    );
                //try ... catch ... finally             
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            ExceptionsCreate3();
        }
        public override void Coddition_Create_Type_Method_2()
        {
            ExceptionsCreate();
        }
        public override void Coddition_Create_Type_Method_3()
        {
            ExceptionsCreate1();
        }
        public static void ExceptionsCreate()
        {
            int[] nums = new int[4];
            try
            {
                nums[5] = 10; 
                //вылетит ошибка IndexOutOfRange , без обработчика исключений try catch
                int x = 0;
                int y = 9 / x;
                Console.WriteLine("End of try block");
            }       
            catch (DivideByZeroException ex) 
            //объект исключения можно передовать в блок catch в скобках
            //общий тип исключений Exception ex
            {
                Console.WriteLine($"Error occured divided{ ex.Message}"); 
            //в консоль выведится , вместо ошибки IndexOutOfRange
            //ex.Message - даст сообщение Индекс находится вне границ массива
            }
            catch (IndexOutOfRangeException ex) 
            //объект исключения можно передовать в блок catch в скобках
            {
                Console.WriteLine($"Error occured mas { ex.Message}"); 
            //в консоль выведится , вместо ошибки IndexOutOfRange
            //ex.Message - даст сообщение Индекс находится вне границ массива
            }
            catch (Exception ex) 
            //объект исключения можно передовать в блок catch в скобках
            //общий тип исключений Exception ex входят все исключения
            {
                Console.WriteLine($"Error occured { ex.Message}");
            //в консоль выведится , вместо ошибки IndexOutOfRange
            //ex.Message - даст сообщение Индекс находится вне границ массива
            }
            finally   
            //всегда выполняется блок finally 
            {
                Console.WriteLine("finally block");
            }
        }
        public static void ExceptionsCreate1()
        {
           try
            {
                Console.WriteLine("Введите строку");
                string message = Console.ReadLine();
                if(message.Length > 6)
                {
                    throw new Exception("Длинна строки больше 6 символов"); // генерируется исключение типа Exception , при условии что строка длиннее 6 символов
                }
                Console.WriteLine("End of try block");
            }
            catch
            {
                Console.WriteLine();
            }          
        }
        public static void ExceptionsCreate3()
        {
            int[] nums = new int[4];
            try
            {
                nums[5] = 10;
                //вылетит ошибка IndexOutOfRange , без обработчика исключений try catch
                int x = 0;
                int y = 9 / x;
                Console.WriteLine("End of try block");
            }
            catch (Exception ex1)
            // объект исключения можно передовать в блок catch в скобках


            //  общий тип исключений Exception ex входят все исключения
            {
                Console.WriteLine($"Error occured { ex1.Message}");
                // в консоль выведится , вместо ошибки IndexOutOfRange


                //  ex.Message - даст сообщение Индекс находится вне границ массива
            }
        }
    }
}
