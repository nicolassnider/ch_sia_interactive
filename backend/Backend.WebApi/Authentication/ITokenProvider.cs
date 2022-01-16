using Backend.Models;
using Microsoft.IdentityModel.Tokens;
using System;

namespace Backend.WebApi.Authentication
{
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime expiry);
        TokenValidationParameters GetValidationParameters();

    }
}
