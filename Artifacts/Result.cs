using MrP.FluentResult.Interfaces;

namespace MrP.FluentResult.Artifacts
{
    public record Result : IFluentResult
    {
        public bool IsSuccess { get; init; }
        public List<string> Messages { get; init; } = [];
        public List<string> ErrorMessages { get; init; } = [];
        public Result() { }
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}
