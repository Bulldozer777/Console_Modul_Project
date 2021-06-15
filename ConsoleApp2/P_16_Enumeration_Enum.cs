using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Training_Csharp
{
   
   
    enum Days // int имеет тип по умолчанию 
    {
        Monday = 1,   //1
        Tuesday,    //2
        Wednesday,    //3
        Thursday,     //4
        Friday,
        Saturday,
        Sunday

    }
    class P_16_Enumeration_Enum
    {
        enum Days1 // int имеет тип по умолчанию 
        {
            Monday ,   //0
            Tuesday,    //1
            Wednesday,    //2
            Thursday,     //3
            Friday,
            Saturday,
            Sunday

        }
        enum Days2 // int имеет тип по умолчанию 
        {
            Monday,   //0
            Tuesday,    //1
            Wednesday,    //2
            Thursday,     //3
            Friday = 17,
            Saturday,   //18
            Sunday

        }
        enum Operation // int имеет тип по умолчанию 
        {
            Add,   //0
            Substract,    //1
            Multiply,    //2
            Divide,     //3
        }
        
        static void Enumeration_Enum_Create(double x, double y, Operation op)  // public модификатор нельзя поставить
        {
            double result = 0.0;
            switch(op)
            {
                case Operation.Add:
                  result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;

            }
            Console.WriteLine(result);

        }
        public static void Enumeration_Enum_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 16)
            {
                Days day;   // переменная day
                day = Days.Friday;
                Console.WriteLine(day);
                Console.WriteLine((int)day);
                Enumeration_Enum_Create(10, 15, Operation.Add);  // результат 25
                Enumeration_Enum_Create(10, 15, Operation.Multiply); //150
            }
            Program.EndInStart();
        }
       
    }
}
