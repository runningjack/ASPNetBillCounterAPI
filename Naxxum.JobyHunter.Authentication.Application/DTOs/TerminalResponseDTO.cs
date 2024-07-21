using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Application.DTOs
{
    public class TerminalResponseDTO
    {
        public string TerminalId { get; set; }
        public string Location { get; set; }
        public int BaudRate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}
