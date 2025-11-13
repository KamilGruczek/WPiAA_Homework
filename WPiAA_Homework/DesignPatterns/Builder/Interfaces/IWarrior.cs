namespace WPiAA_Homework.DesignPatterns.Builder.Interfaces
{
    internal interface IWarrior
    {
        string Name { get; set; }
        int Age { get; set; }
        string Weapon { get; }
        void Fight();
    }
}
