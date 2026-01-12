using Bridge.OperatingSystemInterfaces;

namespace Bridge.OperatingSystems
{
    internal class LinuxSystem(Interface userInterface) : System(userInterface)
    {
        internal override List<string> GetInstalledPrograms()
        {
            return new List<string>
            {
                "Googler",
                "Terminal",
                "Vim",
                "Nmap",
                "Apache"
            };
        }
    }
}
