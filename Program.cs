
using Serilog;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create Logger
            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.LiterateConsole()
                .WriteTo.RollingFile("logs/myapp-{Date}.txt")
                .CreateLogger();

            logger.Information("Hello, world!");

            int a = 10, b = 0;
            try
            {
                logger.Debug("Dividing {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Something went wrong");
            }

            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
