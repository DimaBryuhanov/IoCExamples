using IoCExamples.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCExamples.Models
{
    class ProductService
    {
        public void Log(string message)
        {
            ILogger logger = new FileLogger();
            logger.Log(message);
        }

    }
}
