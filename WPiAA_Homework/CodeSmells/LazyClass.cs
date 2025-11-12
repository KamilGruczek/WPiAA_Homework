namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class LazyClass
    {
    }

    public class MessagingService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }
}
