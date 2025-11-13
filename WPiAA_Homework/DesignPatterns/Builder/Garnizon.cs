using WPiAA_Homework.DesignPatterns.Builder.Interfaces;

namespace WPiAA_Homework.DesignPatterns.Builder
{
    internal class Garnizon
    {
        private List<IWarrior> _warriors = new List<IWarrior>();
        private readonly PiechurBuilder _piechurBuilder = new PiechurBuilder();
        private readonly KonnyBuilder _konnyBuilder = new KonnyBuilder();
        private readonly StrzelecBuilder _strzelecBuilder = new StrzelecBuilder();

        public List<IWarrior> CreateGarnizon()
        {
            _warriors.Add(TrainWarrior(_piechurBuilder));
            _warriors.Add(TrainWarrior(_piechurBuilder));
            _warriors.Add(TrainWarrior(_konnyBuilder));
            _warriors.Add(TrainWarrior(_konnyBuilder));
            _warriors.Add(TrainWarrior(_strzelecBuilder));
            _warriors.Add(TrainWarrior(_strzelecBuilder));

            return _warriors;
        }

        private IWarrior TrainWarrior(WarriorBuilder builder)
        {
            builder.BuildWarrior(Path.GetTempFileName().Split('.')[0], new Random().Next(18, 30));
            builder.BuildWeapon();
            builder.Train();

            return builder.Warrior;
        }
    }
}
