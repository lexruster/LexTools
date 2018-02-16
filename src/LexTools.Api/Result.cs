using System;

namespace LexTools.Api
{
    /// <summary>
    /// Result with data or specific error or unknown error
    /// Alpha version, NO STABLE!
    /// For empty result case usage <see cref="VoidResult"/>
    /// For empty error  case usage <see cref="VoidError"/>
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    /// <typeparam name="TError"></typeparam>
    public class Result<TData, TError>
        where TError : struct
        //todo
        //where TData : IResponse 
    {
        [Obsolete("ONLY FOR SERIALIZABLE!")]
        public Result() { }
        public Result(TData result) : this(result, null)
        {
        }

        public Result(TError error) : this(default(TData), error)
        {
        }

        private Result(TData data, TError? error)
        {
            Data = data;
            Error = error;
        }

        public static Result<TData, TError> UnknownError =>
            new Result<TData, TError>(default(TData), null)
            {
                IsUnknownError = true
            };


        public static Result<TData, TError> Create(TData data)
        {
            return new Result<TData, TError>(data);
        }

        public static Result<TData, TError> Create(TError error)
        {
            return new Result<TData, TError>(error);
        }

        public bool IsUnknownError { get; set; }

        public TData Data { get; set; }

        public TError? Error { get; set; }

        public bool IsSuccess => !Error.HasValue && !IsUnknownError;

        public override string ToString()
        {
            return IsSuccess 
                ? $"Success result. Data: {Data}" 
                : $"Fail result. Error: {Error}";
        }
    }
}