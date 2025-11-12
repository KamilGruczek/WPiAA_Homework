namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class GodClass
    {
    }

    public class AdminPanel(UserManager userManager, SystemConfigurator systemConfigurator, LogRegistrar logRegistrar, SystemReportGenerator systemReportGenerator)
    {

    }

    public class UserManager
    {
        public void ManageUsers()
        {
            Console.WriteLine("Managing users.");
        }
    }

    public class SystemConfigurator
    {
        public void ConfigureSystem()
        {
            Console.WriteLine("Configuring system.");
        }
    }

    public class LogRegistrar
    {
        public void RegisterLog(string log)
        {
            Console.WriteLine($"Log: {log}");
        }
    }

    public class SystemReportGenerator
    {
        public void GenerateSystemReport()
        {
            Console.WriteLine("System report generated.");
        }
    }
}
