using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_F_32_Polymorphism_And_Method_Redefinition : Modul_Struct
    {
        public static void Z_F_32_Polymorphism_And_Method_Redefinition_Info(int a)
        {
            if (a == 32)
            {
                Modul_Struct thirty_two = new Z_F_32_Polymorphism_And_Method_Redefinition();
                Modul_Struct_Start_With_DB(a, thirty_two,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {

        }
        public static void Z_F_32_Polymorphism_And_Method_Redefinition_Create()
        {

        }
    }
}
