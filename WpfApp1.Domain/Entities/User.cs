using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Domain.Commons;
using XSystem.Security.Cryptography;

namespace WpfApp1.Domain.Entities
{
    public class User : Auditable
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
