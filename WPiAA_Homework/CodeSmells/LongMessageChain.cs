namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class LongMessageChain
    {
        public void Example()
        {
            var school = new School();
            string teacherName = school.GetTeacherName();
        }
    }

    public class School
    {
        public string GetTeacherName()
        {
            return GetClassroom().GetTeacher().GetName();
        }

        private Classroom GetClassroom()
        {
            return new Classroom();
        }
    }

    public class Classroom
    {
        public Teacher GetTeacher()
        {
            return new Teacher();
        }
    }

    public class Teacher
    {
        public string GetName()
        {
            return "John Smith";
        }
    }
}
