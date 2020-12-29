using System.IO;
using System.Text;

namespace TrinityItemCreator
{
    static class BinaryReaderExtensions
    {
        public static BinaryReader FromFile(string fileName)
        {
            return new BinaryReader(new FileStream(fileName, FileMode.Open), Encoding.UTF8);
        }

        public static string ReadStringNull(this BinaryReader reader)
        {
            byte num;
            string text = string.Empty;
            System.Collections.Generic.List<byte> temp = new System.Collections.Generic.List<byte>();

            while ((num = reader.ReadByte()) != 0)
                temp.Add(num);

            text = Encoding.UTF8.GetString(temp.ToArray());

            return text;
        }
    }
}