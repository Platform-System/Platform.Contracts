namespace Platform.Common.Grpc;

public static class ResponseStatusExtensions
{
    public static ResponseStatus Success()
        => new()
        {
            IsSuccess = true
        };

    public static ResponseStatus Failure(string errorMessage)
        => new()
        {
            IsSuccess = false,
            Errors =
            {
                errorMessage
            }
        };

    public static bool IsFailure(this ResponseStatus? status)
        => status is null || !status.IsSuccess;

    public static string GetFirstErrorOrDefault(this ResponseStatus? status, string defaultMessage)
        => status?.Errors.FirstOrDefault() ?? defaultMessage;
}
