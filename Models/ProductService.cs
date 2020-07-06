using System;
using System.Collections.Generic;
using System.Text;

namespace IoCExamples.Models
{
    class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        public void Log(string message)
        {
            _fileLogger.Log(message);
        }
    }
}
