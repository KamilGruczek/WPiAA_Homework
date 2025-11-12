namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class MessageChains
    {
        public static void DisplayCarEngineSize(Car car)
        {
            var engineSize = car.GetCylinderSize();
            Console.WriteLine($"Engine Size: {engineSize}");
        }
    }

    public class Car
    {
        public string GetCylinderSize()
        {
            var engine = GetEngine();
            var cylinder = engine.GetCylinder();
            return cylinder.GetSize();
        }

        public Engine GetEngine()
        {
            return new Engine();
        }
    }

    public class Engine
    {
        public Cylinder GetCylinder()
        {
            return new Cylinder();
        }
    }

    public class Cylinder
    {
        public string GetSize()
        {
            return "2.0L";
        }
    }
}
