using IoCExamples.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCExamples.Models
{
    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger.");
            LogToFile(message);
        }
        private void LogToFile(string message)
        {
            Console.WriteLine("Method: LogToFile, Text: {0}", message);
        }
    }
}
