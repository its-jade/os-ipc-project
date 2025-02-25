using System;

namespace LogGenerator {
    public class Program {
        public static void Main(string[] args) {
            string[] logLevels = new string[] { "INFO", "WARNING", "ERROR" };
            Random random = new();

            for (int i = 0; i < 10; i++) {

                string level = logLevels[random.Next(logLevels.Length)];
                switch (level) {
                    case "INFO":
                        Console.WriteLine($"[{level}] {DateTime.Now} - Here is information");
                        Thread.Sleep(1000);
                        break;

                    case "WARNING":
                        Console.WriteLine($"[{level}] {DateTime.Now} - This is a WARNING message");
                        Thread.Sleep(1000);
                        break;

                    case "ERROR":
                        Console.WriteLine($"[{level}] {DateTime.Now} - THERE IS AN ERROR");
                        Thread.Sleep(1000);
                        break;

                    default:
                        Console.WriteLine($"[UNKNOWN] {DateTime.Now} - This is a log message");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }
    }
}
