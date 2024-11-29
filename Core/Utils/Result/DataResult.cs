using Core.Entities;

namespace Core.Utils.Result;

public class DataResult<T> : Result, IDataResult<T>
    where T : class, IDto, new()  //Bu kısıtlamalar, DataResult<T> sınıfının yalnızca DTO (Data Transfer Object) türlerine uygulanmasını sağlar.
{
    public DataResult(T data, bool success, string message) : base(success,message)
    {
        Data = data;
    }
    public DataResult(T data, bool success) : base(success)
    {
        Data = data;
    }

    public T Data { get; set; }
}
