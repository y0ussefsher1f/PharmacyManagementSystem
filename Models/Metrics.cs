using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PharmacyManagementSystem.Models
{
    public static class Metrics
    {
        public static int ExceptionCount { get; private set; } = 0;
        public static Stopwatch Stopwatch { get; } = new Stopwatch();
        public static long MemoryUsage { get; private set; } = 0;
        public static List<string> ExceptionLog { get; } = new List<string>();

        public static void IncrementException(Exception ex)
        {
            ExceptionCount++;
            ExceptionLog.Add($"{DateTime.Now}: {ex.GetType().Name} - {ex.Message}");
        }

        public static void UpdateMemoryUsage()
        {
            MemoryUsage = GC.GetTotalMemory(false);
        }
    }
}