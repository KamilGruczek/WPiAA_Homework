
namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class LongMethod
    {
    }

    public class GradeBook
    {
        private int _grade;
        private bool _isFinalized;

        public int Grade => _grade;

        public bool IsFinalized => _isFinalized;

        internal void SetGrade(int grade)
        {
            _grade = grade;
        }

        internal void Finalize()
        {
            _isFinalized = true;
        }
    }

    public class Teacher
    {
        public void FinalizeGrades(GradeBook gradeBook)
        {
            gradeBook.SetGrade(90);
            gradeBook.Finalize(); // Bezpośrednie ustawianie prywatnych pól
        }
    }
}
