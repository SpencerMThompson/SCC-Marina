﻿using SCC_Marina.Database;
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
                    Message = "Username is invalid!",
                    Code = (int)HttpStatusCode.Unauthorized
                };
            }

            if (!HashManager.VerifyPassword(model.Password, user.Password))
            {
                return new ResultModel
                {
                    IsSuccessful = false,
                    Message = "Password is invalid!",
                    Code = (int)HttpStatusCode.Unauthorized
                };
            }

            return new ResultModel
            {
                IsSuccessful = true,
                Data = user,
                Message = "User Logged in successfully!",
                Code = (int)HttpStatusCode.OK
            };
        }

        public async Task<ResultModel> Register(RegisterModel model)
        {
            var userExists = _dbContext.Users.Any(u => u.Username == model.Username);

            if (!userExists)
            {
                var user = _dbContext.Users.Add(new Entities.User
                {
                    Username = model.Username,
                    Password = model.Password,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                });
                
                await _dbContext.SaveChangesAsync();

                return new ResultModel
                {
                    IsSuccessful = true,
                    Data = user,
                    Message = "User successfully registered!",
                    Code = (int)HttpStatusCode.OK
                };
            }
            else
            {
                return new ResultModel
                {
                    IsSuccessful = false,
                    Data = null,
                    Message = "Username already exists!",
                    Code = (int)HttpStatusCode.BadRequest
                };
            }
        }
    }
}