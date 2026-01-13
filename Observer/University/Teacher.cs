using Observer.Interfaces;

namespace Observer.University
{
    internal class Teacher : ISubject
    {
        private List<Result> _results = [];
        private List<IObserver> _observers = [];

        public string Name { get; }
        public string Subject { get; }

        public Teacher(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }

        public void AddObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(Result result)
        {
            if (result.Student is IObserver observer && _observers.Contains(observer))
            {
                observer.Update(result);
            }
        }

        internal void AddResults(List<Result> results)
        {
            foreach (var result in results)
            {
                _results.Add(result);
                NotifyObservers(result);
            }
        }
    }
}
