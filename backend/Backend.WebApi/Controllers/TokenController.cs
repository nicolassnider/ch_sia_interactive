using Backend.Models;
using Backend.UnitOfWork;
using Backend.WebApi.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Configuration;

namespace Backend.WebApi.Controllers
{
    [Route("api/Token")]
    public class TokenController:Controller
    {
        private ITokenProvider _tokenProvider;
        private IUnitOfWork _unitOfWork;

        public TokenController(ITokenProvider tokenProvider,IUnitOfWork unitOfWork)
        {
            _tokenProvider = tokenProvider;
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public JsonWebToken Post([FromBody]User userLogin)
        {
            var user = _unitOfWork.User.ValidateUser(userLogin.Email,userLogin.Password);
            if (user == null) throw new UnauthorizedAccessException();
            int hoursExpiry = 8;
            int minutesExpiry = hoursExpiry * 60;
            var token = new JsonWebToken
            {
                Access_Token = _tokenProvider.CreateToken(user, DateTime.UtcNow.AddHours(hoursExpiry)),
                Expires_in = minutesExpiry
            };
            return token;

        }
    }
}
