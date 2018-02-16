namespace LexTools.Converter.Binary
{
    public interface IHexConverter
    {
        byte[] GetBytes(string hexString);

        string GetString(byte[] bytes);
    }
}