namespace MrP.GenericResult.Interfaces
{
    public interface IFluentResult
    {
        bool IsSuccess { get; }
        List<string> Messages { get; }
        List<string> ErrorMessages { get; }
    }
}
