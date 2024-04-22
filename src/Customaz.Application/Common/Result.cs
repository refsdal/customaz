namespace Customaz.Application.Common;

public class Result
{
    public readonly string Message;
    public readonly bool IsSuccessful = false;
    public bool IsFailure => !IsSuccessful;

    protected Result(string message, bool isSuccessful)
    {
        Message = message;
        IsSuccessful = isSuccessful;
    }

    public static Result Failure(string message) => new(message, false);
}

public class Result<T> : Result
{
    public readonly T Value;

    private Result(T value, string message, bool isSuccessful) : base(message, isSuccessful)
    {
        Value = value;
    }

    public static new Result<T> Failure(string message) => new(default!, message, false);
    public static implicit operator Result<T>(T value) => new(value, String.Empty, true);
}
