using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Terminal
    {
        public int TerminalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        public Terminal(int terminalId, string name, string address, string city, string province)
        {
            TerminalId = terminalId;
            Name = name;
            Address = address;
            City = city;
            Province = province;
        }
    }
}
