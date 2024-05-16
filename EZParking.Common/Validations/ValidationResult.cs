namespace EZParking.Common.Validations
{
    public sealed class ValidationResult : Result, IValidationResult
    {
        public ValidationResult() : base(true, Error.None)
        {
            Errors = [];
        }

        public ValidationResult(Error[] errors) : base(false, IValidationResult.ValidationError)
        {
            Errors = errors;
        }

        public Error[] Errors { get; }

        public static ValidationResult WithErrors(Error[] errors) => new(errors);
    }
}
