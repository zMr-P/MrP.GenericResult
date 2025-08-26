using MrP.GenericResult.Interfaces;

namespace MrP.GenericResult.Artifacts
{
    public sealed record Result<T> : Result, IFluentResult where T : notnull
    {
        public T Value { get; init; }
        public Result(T value, bool isSuccess)
        {
            Value = value;
            IsSuccess = isSuccess;
        }
    }
}
