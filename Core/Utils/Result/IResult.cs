namespace Core.Utils.Result;

public interface IResult
{
    public bool Success { get; set; }
    public string Message { get; set; }
}
