using Bussiness.Dtos.Requests.Token;
using Bussiness.Dtos.Responses.Token;

namespace Bussiness.Abstract;

public interface ITokenService
{
    public Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest request);
}
