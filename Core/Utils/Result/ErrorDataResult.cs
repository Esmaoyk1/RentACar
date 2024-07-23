using Core.Entities;

namespace Core.Utils.Result;

public class ErrorDataResult<T> : DataResult<T>
    where T : class, IDto, new()
{
    public ErrorDataResult(T data, string message) : base(data, false, message)
    {

    }
    public ErrorDataResult(T data) : base(data, false)
    {

    }
    public ErrorDataResult(string message) : base(default, false, message)
    {

    }
    public ErrorDataResult() : base(default, false)
    {

    }
}
