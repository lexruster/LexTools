using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LexTools.Utilit.System
{
    public static class CloneTool
    {
        public static T DeepCopy<T>(T other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
