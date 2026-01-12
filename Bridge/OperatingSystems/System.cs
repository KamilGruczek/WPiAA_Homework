using Bridge.OperatingSystemInterfaces;

namespace Bridge.OperatingSystems
{
    internal abstract class System(Interface userInterface)
    {
        internal abstract List<string> GetInstalledPrograms();
        internal void DisplayMenu()
        {
            var programs = GetInstalledPrograms();
            userInterface.DisplayMenu(programs);  // Delegacja do implementacji
        }
    }
}
