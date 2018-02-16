namespace LexTools.Api
{
    /// <summary>
    /// Empty result class for <see cref="Result{TData,TError}"/>
    /// </summary>
    public sealed class VoidResult : IResponse
    {
        public static VoidResult New => new VoidResult();
    }
}