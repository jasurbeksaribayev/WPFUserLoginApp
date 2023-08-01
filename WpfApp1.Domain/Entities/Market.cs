using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Domain.Commons;

namespace WpfApp1.Domain.Entities
{
    public class Market : Auditable
    {
        public string Name { get; set; }
    }
}
