namespace Adapter
{
    internal class FakeAdult : Adult
    {
        public override bool IsAdult(int age)
        {
            return age >= 17;
        }
    }
}
