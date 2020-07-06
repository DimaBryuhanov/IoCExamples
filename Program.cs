using IoCExamples.Interfaces;
using IoCExamples.Models;
using System;

namespace IoCExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            ProductService productService = new ProductService(logger);
            productService.Log("Hello World!");
        }
    }
}
