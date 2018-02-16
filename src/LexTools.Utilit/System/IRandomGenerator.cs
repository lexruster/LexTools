namespace LexTools.Utilit.System
{
    public interface IRandomGenerator
    {
        int Next();
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        void NextBytes(byte[] buffer);
        double NextDouble();
        T NextValue<T>(params T[] values);
    }
}