using Observer.Interfaces;

namespace Observer.University
{
    internal class Student : IObserver
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Update(Result result)
        {
            Console.WriteLine($"Notification for {Name}: New result received from {result.Teacher.Name} with score {result.Score}.");
        }
    }
}
