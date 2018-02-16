namespace LexTools.Contract.Validation
{
    public class ValidationError
    {
        public string Field { get; set; }
        public string Description { get; set; }

        public ValidationError()
        {
        }

        public ValidationError(string field, string description)
        {
            Field = field;
            Description = description;
        }
    }
}