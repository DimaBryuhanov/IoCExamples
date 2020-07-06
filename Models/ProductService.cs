using System;
using System.Collections.Generic;
using System.Text;

namespace IoCExamples.Models
{
    class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        private readonly DatabaseLogger _databaseLogger =
          new DatabaseLogger();
        public void Log(string message)
        {
            _fileLogger.Log(message);
        }
        public void LogToDatabase(string message)
        {
            _fileLogger.Log(message);
        }
    }
}
