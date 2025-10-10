using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseRelated;
using Application.DTOs;

namespace Application.Services
{
    public class TerminalService
    {
        private readonly TerminalRepository repo;
        public TerminalService() 
        {
            repo = new TerminalRepository();
        }
        public List<TerminalDetailsDTO> DisplayTerminals()
        {
            var terminal = repo.GetAllTerminals();

            var dtolist = new List<TerminalDetailsDTO>();

            foreach (var t in terminal)
            {
                var dto = new TerminalDetailsDTO(
                    
                    terminalId: t.TerminalId,
                    terminalName: t.Name
                    
                    );
                dtolist.Add(dto);

            }
            return dtolist;
        }
    }
}
