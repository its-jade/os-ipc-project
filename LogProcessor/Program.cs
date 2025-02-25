﻿using System;
using System.Diagnostics;

namespace LogProcessor {
    public class Program {
        public static void Main(string[] args) {
            string? line;

            Stopwatch stopwatch = new();
            stopwatch.Start();

            while ((line = Console.ReadLine()) != null) {
                // Thread.Sleep(2000); // simulate slow process

                // handle if no log message
                if (string.IsNullOrWhiteSpace(line)) {
                    Console.WriteLine("There was an empty log");
                    continue;
                }

                if (line.StartsWith("[ERROR]")) {
                    Console.WriteLine($"🔴ALERT: {line}");

                } else if (line.StartsWith("[WARNING]")) {
                    Console.WriteLine($"🟡ALERT: {line}");

                } else if (line.StartsWith("LogGenerator")) {
                    Console.WriteLine($"{line}");

                } else {
                    Console.WriteLine($"Processed: {line}");
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"LogProcessor Time Elapsed: {stopwatch.Elapsed:hh\\:mm\\:ss\\.fff}");
        }
    }
}
