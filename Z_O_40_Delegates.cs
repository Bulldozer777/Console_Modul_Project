using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
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
                Console.WriteLine("Ввведите 1 чтобы запустить службу, 2 остановить");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Z_O_40_Delegates_Create();
                    //StartService("Центр обновления Windows");
                }
                if (i == 2)
                {
                    StopService("Центр обновления Windows");
                }
                Console.ReadKey();
                //Modul_Struct forty = new Z_O_40_Delegates();
                //Modul_Struct_Start_With_DB(a, forty,                 // использовать именнованные параметры, пример (x:2, y:3)
                //    OperationInfo1_p: Code_Writer_Console(a, 1),
                //    NameCreate1_p: "3 версии методов",
                //    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_O_40_Delegates_Create()
        {
            ProcessStartInfo procInfo;
            // исполняемый файл программы - браузер хром
            //procInfo.FileName = "C://Program Files (x86)//Google//Chrome//Application//chrome.exe";
            //// аргументы запуска - адрес интернет-ресурса
            //procInfo.Arguments = "";
            procInfo = new ProcessStartInfo(@"\\10.94.74.2\C$\Windows\System32\cmd.exe", @"/k sc stop RussianPostEASupdate");
            //procInfo.Verb = "runas";
            //procInfo.FileName = @"\\10.94.74.2\C$\Windows\System32\cmd.exe";
            //// аргументы запуска - адрес интернет-ресурса
            //procInfo.Arguments = @"/k sc stop RussianPostEASupdate";
            Process.Start(procInfo);
        }
        public static void StopService(string serviceName)
        {
            ServiceController service = new ServiceController(serviceName);
            // Если служба не остановлена
            if (service.Status != ServiceControllerStatus.Stopped)
            {
                // Останавливаем службу
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1));
                Console.WriteLine("Служба была успешно остановлена!");
            }
            else
            {
                Console.WriteLine("Служба уже остановлена!");
            }
        }
        public static void StartService(string serviceName)
        {
            ServiceController service = new ServiceController(serviceName);
            // Проверяем не запущена ли служба
            if (service.Status != ServiceControllerStatus.Running)
            {
                // Запускаем службу
                service.Start();
                // В течении минуты ждём статус от службы
                service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
                Console.WriteLine("Служба была успешно запущена!");
            }
            else
            {
                Console.WriteLine("Служба уже запущена!");
            }
        }
    }
}
