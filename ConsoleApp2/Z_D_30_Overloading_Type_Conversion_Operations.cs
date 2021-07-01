using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_D_30_Overloading_Type_Conversion_Operations : Modul_Struct
    {
        public static void Z_D_30_Overloading_Type_Conversion_Operations_Info(int a)
        {
            if (a == 30)
            {
                Modul_Struct thirty = new Z_D_30_Overloading_Type_Conversion_Operations();
                Modul_Struct_Start_With_DB(a, thirty,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_D_30_Overloading_Type_Conversion_Operations_Create()
        {

        }
    }
}
