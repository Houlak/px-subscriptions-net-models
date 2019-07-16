using System;
using System.Collections.Generic;
using System.Text;

namespace Goova.Canal10.Models
{
    public class ChangePasswordRequest
    {
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
