namespace Adapter
{
    internal class Adult
    {
        public virtual bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}
