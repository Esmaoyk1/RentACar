using Core.Entities;

namespace Core.Utils.Result;

public interface IDataResult<T> : IResult
    where T : class, IDto, new()
{
    public T Data { get; set; }
}

//IDataResult<T>, bir işlemin sonucunu (Success, Message) ve işlem sonucunda elde edilen veriyi (Data) birlikte döndürmek için kullanılan bir arayüzdür. 