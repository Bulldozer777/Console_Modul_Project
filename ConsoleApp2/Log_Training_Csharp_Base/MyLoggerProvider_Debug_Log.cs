using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp.Log_Training_Csharp_Base
{
    public class MyLoggerProvider_Debug_Log : ILoggerProvider
    {
            public ILogger CreateLogger(string categoryName)
            {
                return new MyLogger();
            }
            public void Dispose() { }

            private class MyLogger : ILogger
            {
                public IDisposable BeginScope<TState>(TState state)
                {
                    return null;
                }
                public bool IsEnabled(LogLevel logLevel)
                {
                    return true;
                }
                public void Log<TState>(LogLevel logLevel, EventId eventId,
                        TState state, Exception exception, Func<TState, Exception, string> formatter)
                {
                    DateTime currentDate = DateTime.Now;
                    string NewDateFormat = currentDate.ToString("yyyy-MM-dd"); //из за такого ввода формата даты
                                                                               //лог файл будет создаваться каждую новый день
                    File.AppendAllText($"C:\\Users\\Eduard.Karpov\\source\\repos\\ConsoleApp2_17.06.2021\\ConsoleApp2\\ConsoleApp2\\Log_Training_Csharp_Base\\Training_Scharp_Debug_LOG\\log {NewDateFormat}.txt", formatter(state, exception));
                }
            }
        }
    }

