using MrP.FluentResult.Interfaces;

namespace MrP.FluentResult.FluentExtensions
{
    public static class FluentResultExtensions
    {
        public static T AddMessage<T>(this T result, string message) where T : IFluentResult
        {
            if (result is null) throw new ArgumentNullException(nameof(result));
            if (!string.IsNullOrWhiteSpace(message))
                result.Messages.Add(message);

            return result;
        }
        public static T AddErrorMessage<T>(this T result, string errorMessage) where T : IFluentResult
        {
            if (!string.IsNullOrWhiteSpace(errorMessage))
                result.ErrorMessages.Add(errorMessage);
            return result;
        }

        public static T AddMessages<T>(this T result, List<string> messages) where T : IFluentResult
        {
            result.Messages.AddRange(messages?.Where(m => !string.IsNullOrWhiteSpace(m)) ?? []);
            return result;
        }

        public static T AddErrorMessages<T>(this T result, IEnumerable<string> errorMessages) where T : IFluentResult
        {
            result.ErrorMessages.AddRange(errorMessages?.Where(e => !string.IsNullOrWhiteSpace(e)) ?? []);
            return result;
        }
    }
}
