using Observer.University;

namespace Observer.Interfaces
{
    internal interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(Result result);
    }
}
