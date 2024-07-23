using Core.Entities;

namespace Core.Utils.Result;

public interface IDataResult<T> : IResult
    where T : class, IDto, new()
{
    public T Data { get; set; }
}

