using System;

namespace LexTools.Utilit.System
{
    public class RandomGenerator : IRandomGenerator
    {
        private static readonly Random Random = new Random();

        public int Next()
        {
            return Random.Next();
        }

        public int Next(int maxValue)
        {
            return Random.Next(maxValue);
        }

        public int Next(int minValue, int maxValue)
        {
            return Random.Next(minValue, maxValue);
        }

        public void NextBytes(byte[] buffer)
        {
            Random.NextBytes(buffer);
        }

        public double NextDouble()
        {
            return Random.NextDouble();
        }

        public T NextValue<T>(params T[] values)
        {
            var index = Next(values.Length);

            return values[index];
        }
    }
}