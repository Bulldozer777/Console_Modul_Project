using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using NLog;

namespace Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base
{
    class ApplicationContext : DbContext
    {
        //public static void Log_File_Create()
        //{
        //private readonly File.Create($"C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2\\ConsoleApp2_17.06.2021\\ConsoleApp2\\ConsoleApp2\\Log_Training_Csharp_Base\\mylog.txt");
        //}
        private readonly StreamWriter logStream = new StreamWriter("C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2_17.06.2021\\ConsoleApp2\\ConsoleApp2\\Log_Training_Csharp_Base\\mylog11.txt", true);
        public DbSet<Modul_Struct_Base> Modul_Struct_Bases { get; set; }

        //private readonly System.Action<string> a;
        //public static string a1;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {          
            Database.EnsureCreated();
        }
        //private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        ////...
        ////Log.Info("Log");
        ////Log.Error("Log");
        ////Log.Debug("Log");
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(logStream.WriteLine, new[] { RelationalEventId.CommandExecuted });
        }
        public override void Dispose()
        {
            base.Dispose();
            logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
