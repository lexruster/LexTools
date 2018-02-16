namespace LexTools.Api
{
    public class ApiResponse<TData> where TData : class 
    {
        public ApiResponse(TData data, ErrorResponse error)
        {
            Data = data;
            Error = error;
        }

        public ApiResponse() : this(default(TData), null)
        {

        }

        public ApiResponse(ErrorResponse error) : this(default(TData), error)
        {

        }

        public ApiResponse(TData result) : this(result, null)
        {

        }

        public TData Data { get; set; }
        public ErrorResponse Error { get; set; }

        public bool IsSuccess => Error == null && Data != null;
    }
}
