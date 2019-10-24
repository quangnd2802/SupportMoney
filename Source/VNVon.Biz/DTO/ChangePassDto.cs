using System;
using System.Collections.Generic;
using System.Text;

namespace VNVon.Service.DTO
{
    public class ChangePassDto
    {
        public string Username { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
