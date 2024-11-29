namespace Bussiness.Dtos.Responses.UserResponses;

public class UserLoginResponse
{
    public bool AuthenticateResult { get; set; }
    public string AuthToken { get; set; }
    public DateTime AccessTokenExpireDate { get; set; }
}
