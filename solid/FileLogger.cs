using System;

namespace ConsoleApplication
{
    public class FileLogger : IFileLogger
    {
        public FileLogger()
        {

        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}