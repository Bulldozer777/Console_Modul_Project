using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_R_43_Lambda_Expressions : Modul_Struct
    {
        public static void Z_R_43_Lambda_Expressions_Info(int a)
        {       
            if (a == 43)
            {
                Modul_Struct forty_three = new Z_R_43_Lambda_Expressions();
                Modul_Struct_Start_With_DB(a, forty_three,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_R_43_Lambda_Expressions_Create()
        {

        }
    }
}
