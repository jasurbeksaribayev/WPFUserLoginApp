using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Domain.Commons
{
    public class Auditable
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastModifiesTime { get; set; }
    }
}
