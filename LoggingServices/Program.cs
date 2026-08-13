using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingServices
{
    public class LoggingService
    {
        private ILogging _LogService;
        public LoggingService(ILogging LogService)
        {
            _LogService = LogService;
        }
        public void Log(string message)
        {
            _LogService.Log(message);
        }
    }
    public interface ILogging
    {
        void Log(string message);
    }
    public class LoggingToFileService:ILogging
    {

        public void Log(string message)
        {
            Console.WriteLine($"\nLog to file: {message}");
        }
    }
    public class LoggingToEventLogService : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine($"\nLog to Event Log: {message}");
        }
    }

    public class LoggingToDatabaseService : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine($"\nLog to Database: {message}");
        }
    }
    public class LoggingToExcelService : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine($"\nLog to Database: {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the LoggingService
            LoggingService LoggingService = new LoggingService(new LoggingToFileService());

            // Log to File
            LoggingService.Log("Error Occured line xxx.");

            LoggingService = new LoggingService(new LoggingToEventLogService());

            // Log to Event Log
            LoggingService.Log("Error Occured line xxx.");

            LoggingService = new LoggingService(new LoggingToDatabaseService());

            // Log to Database
            LoggingService.Log("Error Occured line xxx.");

            LoggingService = new LoggingService(new LoggingToExcelService());

            // Log to Excel
            LoggingService.Log("Error Occured line xxx.");

            Console.ReadKey();
        }
    }
}
