﻿using SFirstAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFirstAPIProject.Services
{
    public interface ITokenService
    {
        public string CreateToken(UserDTO userDTO);
    }
}
