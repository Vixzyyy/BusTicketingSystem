using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class TerminalDetailsDTO
    {
        public int TerminalId { get; set; }
        public string TerminalName { get; set; }

        public TerminalDetailsDTO(int terminalId, string terminalName)
        {
            TerminalId = terminalId;
            TerminalName = terminalName;
        }
    }
}
