namespace LexTools.Serialization
{
    public static class JsonCloneTool
    {
        public static T JsonCopy<T>(T other)
        {
            var serializer = new NewtonsoftJsonSerializer();
            var serialized = serializer.Serialize(other);
            var deserialized = serializer.Deserialize<T>(serialized);

            return deserialized;
        }
    }
}
