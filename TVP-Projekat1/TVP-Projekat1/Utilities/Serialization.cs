using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dash.Utilities
{
    internal static class Serialization
    {
        private const string DATA = "Data/";
        private static BinaryFormatter binaryFormatter = new BinaryFormatter();

        public static void Write<T>(string fileName, T objekat)
        {
            if (!Directory.Exists(DATA)) Directory.CreateDirectory(DATA);
            using (Stream stream = File.Open($"{DATA}{fileName}", FileMode.Create))
            {
                binaryFormatter.Serialize(stream, objekat);
            }
        }

        public static T Read<T>(string fileName)
        {
            try
            {
                using (Stream stream = File.Open($"{DATA}{fileName}", FileMode.Open))
                {
                    return (T)binaryFormatter.Deserialize(stream);
                }
            }
            catch            
            { 
                throw new FileNotFoundException();
            }
        }
    }
}
