using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
//using Microsoft.Extensions.Logging;
using NLog;
using Training_Csharp.Log_Training_Csharp_Base;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base
{
   public class ApplicationContext : DbContext
    {
        //public static string Name_Log()
        //{
        //    DateTime currentDate = DateTime.Now;
        //    string NewDateFormat = currentDate.ToString("yyyy-MM-dd");
        //    return NewDateFormat;
        //}
        //private readonly StreamWriter logStream = new StreamWriter($"C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2_17.06.2021\\ConsoleApp2\\ConsoleApp2\\Log_Training_Csharp_Base\\Training_Scharp_Debug_LOG\\log {Name_Log()}.txt", true);
        public DbSet<Modul_Struct_Base> Modul_Struct_Bases { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {      
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
      
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            //optionsBuilder.LogTo(logStream.WriteLine, Microsoft.Extensions.Logging.LogLevel.Debug);
            //optionsBuilder.UseLoggerFactory(MyLoggerFactory_Debug_LOG);
        }
        // устанавливаем фабрику логгера
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == Microsoft.Extensions.Logging.LogLevel.Information)
      .AddProvider(new MyLoggerProvider());  // указываем наш провайдер логгирования
          });

        public static readonly ILoggerFactory MyLoggerFactory_Debug_LOG = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            // или так с более детальной настройкой
            //builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name
            //            && level == LogLevel.Information)
            //       .AddConsole();
        });
        //public override void Dispose()
        //{
        //    base.Dispose();
        //    logStream.Dispose();
        //}


        //string GetDbConnString()
        //{
        //    const string fillerString = "empty or null connection string";
        //    string connectionString = fillerString;
        //    string path = Directory.GetCurrentDirectory() + @"\appsettings_Base_Training_Csharp.json";
        //    try
        //    {
        //        if (File.Exists(path))
        //        {
        //            var builder = new ConfigurationBuilder();
        //            builder.SetBasePath(Directory.GetCurrentDirectory());
        //            var config = builder.AddJsonFile("appsettings_Base_Training_Csharp.json").Build();
        //            string temp = config.GetConnectionString("DefaultConnection");
        //            connectionString = (temp is null) || (temp == "") ? fillerString : temp;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine(ex);
        //        Console.ResetColor();
        //    }
        //    return connectionString;
        //}


        //public override async ValueTask DisposeAsync()
        //{
        //    await base.DisposeAsync();
        //    await logStream.DisposeAsync();
        //}
        //public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingContext>
        //{
        //    public BloggingContext CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
        //        optionsBuilder.UseSqlite("Data Source=blog.db");

        //        return new BloggingContext(optionsBuilder.Options);
        //    }
        //}
    }
}
