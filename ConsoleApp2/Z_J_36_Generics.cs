using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_J_36_Generics : Modul_Struct
    {
        public static void Z_J_36_Generics_Info(int a)
        {
            if (a == 36)
            {
                Modul_Struct thirty_six = new Z_J_36_Generics();
                Modul_Struct_Start_With_DB(a, thirty_six,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_J_36_Generics_Create()
        {

        }
    }
}
