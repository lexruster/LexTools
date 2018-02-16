using System.Collections.Generic;
using System.Linq;

namespace LexTools.Api
{
    public class ErrorResponse
    {
        public ErrorResponse()
        {
            ValidationErrors = new Dictionary<string, string>();
        }

        public string Message { get; set; }
        public Dictionary<string, string> ValidationErrors { get; set; }
        public bool HasValidationErrors => ValidationErrors.Any();

        public override string ToString()
        {
            return Message;
        }
    }
}
