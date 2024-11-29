using Bussiness.Dtos.Requests.UserRequest;
using Bussiness.Dtos.Responses.UserResponses;

namespace Bussiness.Abstract;

public interface IAuthService
{
    public Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request);
}
