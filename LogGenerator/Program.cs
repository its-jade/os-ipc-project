using System;
using System.Diagnostics;

namespace LogGenerator {
    public class Program {
        public static void Main(string[] args) {
            string[] logLevels = new string[] { "INFO", "WARNING", "ERROR" };
            Random random = new();
            int numberOfMessages = 10;

            Stopwatch stopwatch = new();
            stopwatch.Start();

            for (int i = 0; i < numberOfMessages; i++) {
                string level = logLevels[random.Next(logLevels.Length)];
                string message = $"[{level}] {DateTime.Now} - This is a {level} message";

                Console.WriteLine(message);
                Thread.Sleep(1000);
            }

            stopwatch.Stop();
            Console.WriteLine($"\nLogGenerator Time Elapsed: {stopwatch.Elapsed:hh\\:mm\\:ss\\.fff}");
        }
    }
}
