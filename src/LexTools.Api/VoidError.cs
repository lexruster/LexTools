namespace LexTools.Api
{
    /// <summary>
    /// Empty error struct for <see cref="Result{TData,TError}"/>
    /// </summary>
    public struct VoidError
    {
        public static VoidError New=>new VoidError();
    }
}
