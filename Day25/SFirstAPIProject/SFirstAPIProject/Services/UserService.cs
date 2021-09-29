﻿using SFirstAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SFirstAPIProject.Services
{
    public class UserService
    {
        private readonly CompanyContext _context;
        private readonly ITokenService _tokenService;

        //public UserService(ITokenService tokenService)
        //{
        //    _tokenService = tokenService;
        //}
        public UserService(CompanyContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public UserDTO Register(UserDTO userDto)
        {
            try
            {
                using var hmac = new HMACSHA512();
                var user = new User()
                {
                    UserId = userDto.Id,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDto.Password)),
                    PasswordSalt = hmac.Key
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                userDto.jwtToken = _tokenService.CreateToken(userDto);
                userDto.Password = "";
                return userDto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
