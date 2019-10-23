using System;
using System.Collections.Generic;
using System.Text;

namespace VNVon.Service.DTO
{
    public class LoginDTO
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public int UserType { get; set; }

        public string Role { get; set; }
    }
}
