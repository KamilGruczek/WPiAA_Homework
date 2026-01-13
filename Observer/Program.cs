using Observer.University;

Console.WriteLine("Hello in University App.");
var students = new List<Student>
{
    new Student("Alice", 20),
    new Student("Bob", 22),
    new Student("Charlie", 19)
};
var teacher = new Teacher("Dr. Smith", "Mathematics");

teacher.AddObserver(students[0]);
teacher.AddObserver(students[1]);
teacher.AddObserver(students[2]);

var results = new List<Result>
{
    new Result { Teacher = teacher, Student = students[0], Score = 3.5m },
    new Result { Teacher = teacher, Student = students[1], Score = 4.0m },
    new Result { Teacher = teacher, Student = students[2], Score = 5.0m }
};

teacher.AddResults(results);

Console.WriteLine("\nHave a beautiful day!");
Console.ReadKey();
