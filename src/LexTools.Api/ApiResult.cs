using LexTools.Contract;

namespace LexTools.Api
{
    public class ApiResult<TData> : GenericResult<TData, ApiError>
    {
        public ApiResult(TData result)
            : base(result)
        {
        }

        public ApiResult(ApiError error)
            : base(error)
        {
        }

        public ApiResult()
            : this(ApiError.InternalServiceError)
        {
        }
    }
}
