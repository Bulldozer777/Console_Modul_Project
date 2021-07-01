using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_O_40_Delegates : Modul_Struct
    {
        public static void Z_O_40_Delegates_Info(int a)
        {
            if (a == 40)
            {
                Modul_Struct forty = new Z_O_40_Delegates();
                Modul_Struct_Start_With_DB(a, forty,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_O_40_Delegates_Create()
        {

        }
    }
}
