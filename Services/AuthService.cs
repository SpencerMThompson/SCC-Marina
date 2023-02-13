using SCC_Marina.Database;
using SCC_Marina.Helpers;
using SCC_Marina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace SCC_Marina.Services
{
    public class AuthService
    {
        protected MarinaDbContext _dbContext;

        public AuthService()
        {
            _dbContext = new MarinaDbContext();
        }

        /// <summary>
        /// Authenticate User Login
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ResultModel> Authenticate(LoginModel model)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(i => i.Username == model.Username);

            if(user == null)
            {
                return new ResultModel
                {
                    IsSuccessful = false,
                    Message = "Username or password is invalid!",
                    Code = (int)HttpStatusCode.Unauthorized
                };
            }

            if (!HashManager.VerifyPassword(model.Password, user.Password))
            {
                return new ResultModel
                {
                    IsSuccessful = false,
                    Message = "Username or password is invalid!",
                    Code = (int)HttpStatusCode.Unauthorized
                };
            }

            return new ResultModel
            {
                IsSuccessful = true,
                Data = user,
                Message = "User Logged in successfully!",
                Code = (int)HttpStatusCode.Ok
            };
        }
    }
}