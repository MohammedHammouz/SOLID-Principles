using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingServices
{
    public class LoggingService
    {
        public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

        public void Log(string message, enLoggingType LoggingType)
        {
            if (LoggingType == enLoggingType.ToFile)
            {
                LoggingToFileService.Log(message);
            }
            else if (LoggingType == enLoggingType.ToEventLog)
            {
                LoggingToEventLogService.Log(message);
            }
            else if (LoggingType == enLoggingType.ToDatabase)
            {
                LoggingToDatabaseService.Log(message);
            }
        }
    }
    public class LoggingToFileService
    {

        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to file: {message}");
        }
    }
    public class LoggingToEventLogService
    {
        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to Event Log: {message}");
        }
    }

    public class LoggingToDatabaseService
    {
        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to Database: {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the LoggingService
            LoggingService LoggingService = new LoggingService();

            // Log to File
            LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToFile);

            // Log to Event Log
            LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToEventLog);

            // Log to Database
            LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToDatabase);

            Console.ReadKey();
        }
    }
}
