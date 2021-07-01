using System;
using Microsoft.EntityFrameworkCore;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Training_Csharp
{
    class Program : Generation_Operation
    {
        static void Main(string[] args)
        {
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

    



 

