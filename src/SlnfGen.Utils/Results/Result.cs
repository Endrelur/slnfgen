using System.Diagnostics.CodeAnalysis;

namespace SlnfGen.Utils.Results;

public struct SuccessResult();

public static class Result
{
    public static SuccessResult Success => new();
}

public class Result<TError>
{
    protected Result(){ }

    [MemberNotNullWhen(false, nameof(Error))]
    public required virtual bool Success { get; init; }
    
    [MemberNotNullWhen(true, nameof(Error))]
    public bool Failure => !Success;

    public TError? Error { get; init; }
    
    public static implicit operator Result<TError>(TError error) =>
        new()
        {
            Success = false,
            Error = error,
        };
    
    public static implicit operator Result<TError>(SuccessResult _) =>
        new()
        {
            Success = true,
        };
}

public class Result<TValue, TError> : Result<TError>
{
    private Result(){ }

    [MemberNotNullWhen(true, nameof(Value))]
    public required override bool Success { get; init; }

    public TValue? Value { get; init; }

    public static implicit operator Result<TValue, TError>(TError error) =>
        new()
        {
            Error = error,
            Success = false,
        };
    
    public static implicit operator Result<TValue, TError>(TValue value) =>
        new()
        {
            Value = value,
            Success = true,
        };
}