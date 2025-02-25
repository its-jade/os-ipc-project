using System;

namespace LogProcessor {
    public class Program {
        public static void Main(string[] args) {
            string? line;

            while ((line = Console.ReadLine()) != null) {
                if (line.StartsWith("[ERROR]")) {
                    // process the log message (e.g., write to a file, analyze it)
                    Console.WriteLine($"🔴ALERT: {line}");

                } else if (line.StartsWith("[WARNING]")) {
                    Console.WriteLine($"🟡ALERT: {line}");

                } else {
                    Console.WriteLine($"Ignored: {line}");
                }
            }
        }
    }
}
