using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Schools.Model
{
    internal class LoginResult
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public User ConnectedUser { get; set; }
    }
}
