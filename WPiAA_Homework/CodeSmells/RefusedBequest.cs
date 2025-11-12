namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class RefusedBequest
    {
    }

    public class BasicEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public class Employee : BasicEmployee, IEmployee
    {
        public void Work() { /* Implementacja */ }
        public void AttendMeeting() { /* Implementacja */ }
    }

    public class Manager : Employee, IManager
    {
        public void AttendMeeting() { /* Implementacja */ }
        public void ManageTeam() { /* Implementacja */ }
        public void Work() { /* Implementacja */ }
    }

    public interface IEmployee
    {
        void Work();
        void AttendMeeting();
    }

    public interface IManager
    {
        void ManageTeam();
    }
}
