using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class S_19_Exceptions
    {
        public static void ExceptionsInfo(int a)
        {
            Program.ModulRegistr(a);
            if (a == 19)
            {
                //try ... catch ... finally
                ExceptionsCreate();
                ExceptionsCreate1();
            }
            Program.EndInStart();
        }
        public static void ExceptionsCreate()
        {
            int[] nums = new int[4];
            try
            {
                nums[5] = 10; //вылетит ошибка IndexOutOfRange , без обработчика исключений try catch
                int x = 0;
                int y = 9 / x;
                Console.WriteLine("End of try block");
            }
            //catch(Exception ex) //объект исключения можно передовать в блок catch в скобках
            //                    //общий тип исключений Exception ex входят все исключения
            //{
            //    Console.WriteLine($"Error occured { ex.Message}"); //в консоль выведится , вместо ошибки IndexOutOfRange
            //    //ex.Message - даст сообщение Индекс находится вне границ массива
            //}
            catch (DivideByZeroException ex) //объект исключения можно передовать в блок catch в скобках
                                 //общий тип исключений Exception ex
            {
                Console.WriteLine($"Error occured divided{ ex.Message}"); //в консоль выведится , вместо ошибки IndexOutOfRange
                //ex.Message - даст сообщение Индекс находится вне границ массива
            }
            catch (IndexOutOfRangeException ex) //объект исключения можно передовать в блок catch в скобках

            {
                Console.WriteLine($"Error occured mas { ex.Message}"); //в консоль выведится , вместо ошибки IndexOutOfRange
                //ex.Message - даст сообщение Индекс находится вне границ массива
            }
            catch (Exception ex) //объект исключения можно передовать в блок catch в скобках
                                 //общий тип исключений Exception ex входят все исключения
            {
                Console.WriteLine($"Error occured { ex.Message}"); //в консоль выведится , вместо ошибки IndexOutOfRange
                //ex.Message - даст сообщение Индекс находится вне границ массива
            }
            finally   //всегда выполняется блок finally 
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
    }
}
