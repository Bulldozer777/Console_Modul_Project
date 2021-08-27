using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_Q_42_Anonymous_Methods : Modul_Struct
    {
        public static void Z_Q_42_Anonymous_Methods_Info(int a)
        {  
            if (a == 42)
            {
                Modul_Struct forty_two = new Z_Q_42_Anonymous_Methods();
                Modul_Struct_Start_With_DB(a, forty_two,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_Q_42_Anonymous_Methods_Create()
        {

        }
    }
}
