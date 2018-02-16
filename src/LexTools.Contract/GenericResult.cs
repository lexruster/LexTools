namespace LexTools.Contract
{
    public class GenericResult<TData, TError> where TError : struct
    {
        protected GenericResult(TData result, TError? error)
        {
            Data = result;
            Error = error;
        }

        public GenericResult(TData result)
            : this(result, null)
        {
        }

        public GenericResult(TError error)
            : this(default(TData), error)
        {
        }

        public GenericResult()
            : this(default(TError))
        {
            //using for Serializable
        }


        public TData Data { get; set; }

        public TError? Error { get; set; }

        public bool IsSuccess => false == Error.HasValue;

        public override string ToString()
        {
            if (IsSuccess)
            {
                return $"Success result. Data: {Data}";
            }
            return $"Fail result. Error: {Error}";
        }
    }
}
