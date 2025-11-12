namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class DivergentChange
    {
    }

    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AuthenticationService
    {
        public UserAccount Login(string username, string password)
        {
            // Logika logowania
            Console.WriteLine("User logged in.");

            return new UserAccount { Username = username, Password = password };
        }

        public void Logout(UserAccount user)
        {
            // Logika wylogowania
            Console.WriteLine("User logged out.");
        }
    }

    public class UserReportGenerator
    {
        public void GenerateReport(UserAccount user)
        {
            // Logika generowania raportu
            Console.WriteLine("Generating user report.");
        }
    }
}
