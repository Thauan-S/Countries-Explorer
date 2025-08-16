using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Name
    {
        public string Common { get; set; } = string.Empty;
        public string Official { get; set; }=string.Empty;
        public Dictionary<string, NativeName> NativeName { get; set; } = [];
        
    }
}
