using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingServices
{
    public class LoggingService
    {
        private ILogService _LogService;
        public LoggingService(ILogService LogService)
        {
            _LogService = LogService;
        }
        public void Log(string message)
        {
            _LogService.Log(message);
        }
    }
    public interface ILogService
    {
        void Log(string message);
    }
    public class LoggingToFileService:ILogService
    {

        public void Log(string message)
        {
            Console.WriteLine($"\nLog to file: {message}");
        }
    }
    public class LoggingToEventLogService : ILogService
    {
        public void Log(string message)
        {
            Console.WriteLine($"\nLog to Event Log: {message}");
        }
    }

    public class LoggingToDatabaseService : ILogService
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

            Console.ReadKey();
        }
    }
}
