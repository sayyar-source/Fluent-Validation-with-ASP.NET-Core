using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public bool IsEnable { get; set; } = true;
    }
}
