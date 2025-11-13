using Newtonsoft.Json;

namespace WPiAA_Homework.DesignPatterns.Prototype
{
    internal static class ObjectExtension
    {
        private static readonly JsonSerializerSettings _defaultSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            NullValueHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        internal static T Clone<T>(this T source) where T : new()
        {
            var serialized = JsonConvert.SerializeObject(source, _defaultSettings);

            return JsonConvert.DeserializeObject<T>(serialized)!;
        }
    }
}
