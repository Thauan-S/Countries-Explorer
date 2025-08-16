using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Models
{
    public class Country
    {
        public Flags? Flags { get; set; }
        public Name? Name { get; set; }
        public Dictionary<string, Currency> Currencies { get; set; } = [];
        public Currency? Currency => Currencies?.FirstOrDefault().Value;
        public string CurrencyCode => Currencies.FirstOrDefault().Key;
        public List<string> Capital { get; set; } = [];
        public string Region { get; set; } = string.Empty;
    }
}
