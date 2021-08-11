using System;
using Microsoft.EntityFrameworkCore;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Training_Csharp
{
    class Program : Generation_Operation
    {
        public static void Copy_Logs_EAS()
        {
            Console.WriteLine("Введите номер отделения, с которого нужно скопировать логи\n");
            string p1 = Console.ReadLine();
            while (p1.Length != 6) 
            {
                Console.WriteLine("Номер отделения 6 цифр");
                Console.WriteLine("\nВведите номер отделения, с которого нужно скопировать логи\n");
                p1 = Console.ReadLine();
            }
            if (p1.Length == 6)
            {
                Console.WriteLine("\nВведите номер окна отделения, с которого нужно скопировать логи\nПример ввода номера окна: n или w-01\n");
                string p2 = Console.ReadLine();
                Console.WriteLine("\nВведите дату, за которую нужно скопировать логи\n" +
                    "(месяц и число, год будет по умолчанию 2021)\n Пример ввода даты: 0709 (июль 9 число)\n");
                string p3 = Console.ReadLine();
                Directory.CreateDirectory(@"D:\EAS_LOG");
                string path = @"\\r40-" + p1 + "-" + p2 + @"\c$\ProgramData\POS\Logs\2021" + p3 + ".json";
                //string newPath = @"D:\EAS_LOG\2021" + p3 + ".json";
                string path_zip = @"D:\EAS_LOG\2021" + p3 + ".zip";
                Console.WriteLine("\nПоиск логов и копирование по пути:");
                Console.WriteLine(path);
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    Console.WriteLine("\nФайл с именем: 2021" + p3 + ".json - существует\n");
                    Console.WriteLine("Выполняется архивирование файла...");
                    Console.WriteLine("Скорость архивации медленная, так что придется подождать...\nНе волнуемся, программа не повисла...");
                    string sourceFile = path; // исходная папка
                    string zipFile = @"\\r40-" + p1 + "-" + p2 + @"\c$\ProgramData\POS\Logs\2021" + p3 + ".zip";
                    Compress(sourceFile, zipFile);                                                                                           
                    Console.WriteLine("Архивирование завершено\n");
                    FileInfo fileInf_1 = new FileInfo(zipFile);
                    if (fileInf_1.Exists)
                    {
                        Console.WriteLine("Выполняется копирование архивированного файла на диск Вашего ПК...");
                        fileInf.MoveTo(path_zip);
                        Console.WriteLine($"Копирование завершено");
                        Console.WriteLine($"\nЛог файл с именем: 2021" + p3 + $".zip, доблавлен по пути:\n{path_zip}"); ;               
                    }
                }
                else
                {
                    Console.WriteLine($"\nПо пути: {path}");
                    Console.WriteLine("Файл с именем: 2021" + p3 + ".json - не существует\n");                  
                }
            }
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 90; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }
        public static void Compress(string sourceFile, string compressedFile)
        {
            // поток для чтения исходного файла
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                // поток для записи сжатого файла
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    // поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream); // копируем байты из одного потока в другой
                        Console.WriteLine("\nСжатие файла {0} завершено. \nИсходный размер: {1}  \nСжатый размер: {2}.",
                            sourceFile, sourceStream.Length.ToString(), targetStream.Length.ToString());
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Copy_Logs_EAS();
            Console.WriteLine(DateTime.Now);
            InStartString();
            InStart3(int.Parse(Console.ReadLine()));
        }
        public static DbContextOptions<ApplicationContext> Base_Configuration_On_File_Json()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings_Base_Training_Csharp.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
            return options;
        }
    }
}

    



 

