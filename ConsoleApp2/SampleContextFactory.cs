using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;

namespace Training_Csharp
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>


    //Дело в том, что, если в единственный конструктор в классе контекста принимает параметр DbContext:
    //public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    //В этом случае при выполнении миграции инструментарий Entity Frameworkа ищет класс,
    //который реализует интерфейс IDesignTimeDbContextFactory и который задает конфигурацию контекста.


    //Инчае в Консоле диспетчера пакетов возникает ошибка
    //Unable to create an object of type 'ApplicationContext'.
    //For the different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728

    //Хотя этот класс формально нигде не вызывается и никак не используется,
    //фактически он вызывается инфраструктурой Entity Framework при создании миграции.
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            // получаем конфигурацию из файла appsettings.json
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings_Base_Training_Csharp.json");
            IConfigurationRoot config = builder.Build();

            // получаем строку подключения из файла appsettings.json
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
 
    //add-migration First_Migrtion_for_Training_Csharp -Context DbContext -project Training_Csharp

    //Update-Database -Context ApplicationContext
}
