using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AppRetetePDM.Services.Logger
{
    public class LoggerService : ILoggerService
    {
        const string PATH = @"D:\File.txt";
        public void Log(string message)
        {
            File.WriteAllText(PATH, message);
        }
    }
}
