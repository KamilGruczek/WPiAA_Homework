namespace Adapter
{
    internal class NightClub
    {
        private readonly Adult _adultChecker;
        public NightClub(Adult adultChecker)
        {
            _adultChecker = adultChecker;
        }
        public bool CanEnter(int age)
        {
            return _adultChecker.IsAdult(age);
        }
    }
}
