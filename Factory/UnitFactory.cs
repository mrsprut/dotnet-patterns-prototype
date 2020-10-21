using Prototype.Entity;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Prototype.Factory
{
    public static class Extensions
    {

        public static T GetClone<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("Argument isn't serialazible!");
            }

            if (ReferenceEquals(self, null))
            {
                return default(T);
            }

            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }

    public class UnitFactory
    {
        private static Unit human =
            new Unit { appearance = new Appearance { race = "human", arms="sword" } };

        private static Unit elf =
            new Unit { appearance = new Appearance { race = "elf", arms = "sword" } };

        private static Unit newUnit(string name, string size, Unit unit)
        {
            var result = unit.GetClone();
            result.name = name;
            result.appearance.size = size;
            return result;
        }

        public static Unit newHumanUnit(string name, string size)
        {
            return newUnit(name, size, human);
        }

        public static Unit newElfUnit(string name, string size)
        {
            return newUnit(name, size, elf);
        }
    }
}
