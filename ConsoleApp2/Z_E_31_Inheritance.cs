using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_E_31_Inheritance : Modul_Struct
    {
        public static void Z_E_31_Inheritance_Info(int a)
        {
            if (a == 31)
            {
                Modul_Struct thirty_one = new Z_E_31_Inheritance();
                Modul_Struct_Start_With_DB(a, thirty_one,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_E_31_Inheritance_Create()
        {

        }
    }
}
