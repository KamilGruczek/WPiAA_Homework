namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class SpeculativeGenerality
    {
    }

    public class AdvancedHandler
    {
        public void HandleHttpRequest(HttpRequest request)
        {
            Console.WriteLine($"Handling HTTP request: {request.Url}");
        }

        public void HandleFileRequest(FileRequest request)
        {
            Console.WriteLine($"Handling file request: {request.FileName}");
        }
    }
}
