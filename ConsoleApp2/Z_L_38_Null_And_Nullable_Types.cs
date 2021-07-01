using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_L_38_Null_And_Nullable_Types : Modul_Struct
    {
        public static void Z_L_38_Null_And_Nullable_Types_Info(int a)
        {
            if (a == 38)
            {
                Modul_Struct thirty_eight = new Z_L_38_Null_And_Nullable_Types();
                Modul_Struct_Start_With_DB(a, thirty_eight,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_L_38_Null_And_Nullable_Types_Create()
        {

        }
    }
}
