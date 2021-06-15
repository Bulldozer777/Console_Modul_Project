using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class H_8_Conditional_Constructions : Modul_Struct
    {
        public static void H_8_Conditional_Constructions_Info(int a)
        {         
            if (a == 8)
            {
                Modul_Struct Eight = new H_8_Conditional_Constructions();   //нужно создавать объект класса наследника, после ключевого слова new
                operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 2));
                operation_Create_Method_1 = Code_Writer_Console(a, 1);
                Eight.Method_Modul_Start_1();
                Generation_Operation.EndInStart();
            }           
        }
        public override void Create_Method()
        {
            Console.WriteLine("Код метода H_8_Conditional_Constructions_Create()\n");
            Console.WriteLine($"{operation_Create_Method_1}");
            Console.WriteLine("Чтобы запустить метод H_8_Conditional_Constructions_Create()\nНажмите 1\n");
            int y = int.Parse(Console.ReadLine());
            if (y == 1)
            {
                Console.WriteLine("\nРабота метода:\n");
                H_8_Conditional_Constructions_Create();
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число"); 
            }
        }
        
        public static void H_8_Conditional_Constructions_Create()
        {
            //if ... else swith ... case
            int num1 = 8;
                int num2 = 16;
            if (num1 > num2)
                Console.WriteLine("num1 больше чем num2");  
            //если блок кода, выполняемый после if или после else,
            //состоит из 1 строки, то фигурные скобки необязательны 
            if (num1 > num2 && num1 == 8) //условие может выглядеть так
                Console.WriteLine("num1 больше чем num2");
            else if (num1 < num2)
                Console.WriteLine($"{num1} меньше чем {num2}");
            else
                Console.WriteLine($"{num1} равно {num2}");
            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            //каждый case должен завершаться оператором перехода 
            //break, goto case, return - если мы хотим выйти из программы, throw - генерирует ошибку
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали клавишу Y");
                    goto case "N";
                case "N":
                    Console.WriteLine("Вы нажали клавишу N");
                    break; 
                default:
                    Console.WriteLine("Вы нажали неизвестную клавишу");
                    break;
            }
            //Тернарный оператор - требует наличние 3ех операндов
            //op1?op:op3
            int x = 3;
            int y = 2;
            
            Console.WriteLine("Нажмите + или -");
            string selection2 = Console.ReadLine();
            int z = selection2 == "+" ? (x + y) : (x - y);
            //Если пользователь ввел + то выполняется (х + y) т е второй операнд, 
            //Если бы пользователь ввел - то выполнилось (x - y) т е третий операнд
                Console.WriteLine(z);
        }
        public override void Examples_Method()
        {
            Console.WriteLine("Работу с операторами if и else\n можно рассмотреть на примере работы метода Calculating_The_Volume_Of_A_Box()\n который рассчитывает объем короба при выполнении опеределенных условий");
            Console.WriteLine(G_7_If_Else_Operation.Calculating_The_Volume_Of_A_Box());
        }
    }
}
