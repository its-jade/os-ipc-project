using System;

namespace LogGenerator {
    public class Program {
        public static void Main(string[] args) {
            string[] logLevels = new string[] { "INFO", "WARNING", "ERROR" };
            Random random = new();
            int count = 0;

            while (count < 10) {
                count++;
                int index = random.Next(1, 11);
                // generate a random number 1-10
                // if number is 1,
                // print out a slightly different message

                string level = logLevels[random.Next(logLevels.Length)];
                Console.WriteLine($"[{level}] {DateTime.Now} - This is a log message");
                Thread.Sleep(1000);
            }
        }
    }
}
