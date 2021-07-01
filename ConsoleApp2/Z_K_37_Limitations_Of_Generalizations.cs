using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_K_37_Limitations_Of_Generalizations : Modul_Struct
    {
        public static void Z_K_37_Limitations_Of_Generalizations_Info(int a)
        {
            if (a == 37)
            {
                Modul_Struct thirty_seven = new Z_K_37_Limitations_Of_Generalizations();
                Modul_Struct_Start_With_DB(a, thirty_seven,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_K_37_Limitations_Of_Generalizations_Create()
        {

        }
    }
}
