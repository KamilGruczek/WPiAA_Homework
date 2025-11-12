namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class DuplicatedCode
    {
        public static void LogError(string message, DateTime timestamp)
        {
            Console.WriteLine(FormatLogMessage(LogLevel.Error, message, timestamp));
        }

        public static void LogWarning(string message, DateTime timestamp)
        {
            Console.WriteLine(FormatLogMessage(LogLevel.Warning, message, timestamp));
        }

        private static string FormatLogMessage(LogLevel level, string message, DateTime timestamp)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{level.ToString().ToUpper()}: [{formattedTimestamp}] {message}";
        }
    }

    internal enum LogLevel
    {
        Error,
        Warning
    }
}
