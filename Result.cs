namespace MrP.GenericResult
{
    public sealed record Result<T> : Result where T : notnull
    {
        public T Value { get; init; }
        public Result(T value, bool isSuccess)
        {
            Value = value;
            IsSuccess = isSuccess;
        }
    }
    public record Result
    {
        public bool IsSuccess { get; init; }
        public List<string> Messages { get; init; } = [];
        public List<string> ErrorMessages { get; init; } = [];
        public Result() { }
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public Result AddMessage(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                Messages.Add(message);
            }
            return this;
        }

        public Result AddErrorMessage(string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                ErrorMessages.Add(errorMessage);
            }
            return this;
        }

        public Result AddMessages(List<string> messages)
        {
            if (messages is not null && messages.Count > 0)
            {
                Messages.AddRange(messages.Where(message => !string.IsNullOrWhiteSpace(message)));
            }
            return this;
        }

        public Result AddErrorMessages(List<string> errorMessages)
        {
            if (errorMessages is not null && errorMessages.Count > 0)
            {
                ErrorMessages.AddRange(errorMessages.Where(errorMessage => !string.IsNullOrWhiteSpace(errorMessage)));
            }
            return this;
        }
    }
}
