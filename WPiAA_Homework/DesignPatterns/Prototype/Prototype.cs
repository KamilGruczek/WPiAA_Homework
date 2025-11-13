namespace WPiAA_Homework.DesignPatterns.Prototype
{
    internal class Prototype
    {
        public void Run()
        {
            var orks = new List<Ork>();

            var originalOrk = new Ork
            {
                Strength = 10,
                Agility = 5,
                Intelligence = 1
            };

            for (int i = 1; i <= 5; i++)
            {
                var clonedOrk = originalOrk.Clone();
                clonedOrk.Strength += i;
                clonedOrk.Agility += i * 2;

                orks.Add(clonedOrk);
            }

            Console.WriteLine("Original Ork:");
            Console.WriteLine($"Strength: {originalOrk.Strength}, Agility: {originalOrk.Agility}, Intelligence: {originalOrk.Intelligence}");
            Console.WriteLine("Cloned Orks:");

            foreach (var ork in orks)
            {
                Console.WriteLine($"Strength: {ork.Strength}, Agility: {ork.Agility}, Intelligence: {ork.Intelligence}");
            }
        }
    }
}
