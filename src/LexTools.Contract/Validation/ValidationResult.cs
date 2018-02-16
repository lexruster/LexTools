using System.Collections.Generic;
using System.Linq;

namespace LexTools.Contract.Validation
{
    public class ValidationResult
    {
        public IEnumerable<ValidationError> Errors { get; set; }

        public bool IsSuccess => !Errors.Any();

        public ValidationResult()
        {
            Errors = new List<ValidationError>();
        }
    }
}
