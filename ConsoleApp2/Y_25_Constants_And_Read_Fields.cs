using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Y_25_Constants_And_Read_Fields
    {
        public static void Y_25_Constants_And_Read_Fields_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 25)
            {
                int r = MathLib.T;
                //MathLib.T = 9; из вне нельзя изменить значение константы 
                MathLib Obj = new MathLib();
               // Obj.p = 90; - некорректная запись поле реадонли изменить нельзя
                int u = Obj.p; // можно только присвоить
                Console.WriteLine($"Поле Readonly - {u} \nПоле константа {r}");
            }
            Program.EndInStart();
        }
        public static void Y_25_Constants_And_Read_Fields_Create(int a)
        {
          
        }
    }
    class MathLib
    {
        public const int T = 67; // название константы определяется в верхнем регистре
        public readonly int p = 89; //поле для чтения 
        public MathLib() //констурктор
        {
            //  T = 78; некорректное опредление т к переменная это костанта
            p = 78; //- корректная запись в отличие от констант
        }
        public void Some()
        {
            //  T = 78; некорректное опредление т к переменная это костанта
          //  p = 78; //- некорректная запись 
        }
    }
}
