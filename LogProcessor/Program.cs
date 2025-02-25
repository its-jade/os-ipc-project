using System;

namespace LogProcessor {
    public class Program {
        public static void Main(string[] args) {
            string? line;

            while ((line = Console.ReadLine()) != null) { // change this to read the line, and only read it if it's the exact same format
                // Process the log message (e.g., write to a file, analyze it)
                Console.WriteLine($"Processed: {line}");
            }
            // if it's a different format, consider it an error and handle it here
        }
    }
}
