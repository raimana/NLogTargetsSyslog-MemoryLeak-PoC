using System;
using System.Threading;
using NLog;
using NLog.Config;

namespace SyslogTest
{
    class Program
    {
        static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            LogManager.Configuration = new XmlLoggingConfiguration($"{AppContext.BaseDirectory}nlog.config");

            while (true)
            {
                Console.WriteLine("Enter message count...");
                int messageCount = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= messageCount; i++)
                {
                    logger.Info($"Test log message {i}");
                }
            }
        }
    }
}

