using Bridge.OperatingSystemInterfaces;

namespace Bridge.OperatingSystems
{
    internal class WindowsSystem : System
    {
        internal WindowsSystem() : base(new GraphicInterface())
        {
        }

        internal override List<string> GetInstalledPrograms()
        {
            return new List<string>
            {
                "Microsoft Edge",
                "Visual Studio",
                "Microsoft Office",
                "Windows Media Player",
                "Paint"
            };
        }
    }
}
