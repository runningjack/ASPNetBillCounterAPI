using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Entities
{
    public class Terminal :BaseEntity
    {
        public int Id { get; set; }
        public string TerminalId { get; set; }
        public int BaudRate { get; set; }
        public string Model { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
