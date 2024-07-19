namespace TerminalManagement.Application.DTOs
{
    public class TerminalDetailsResponseDTO
    {
        public string TerminalId { get; set; }
        public string Location { get; set; }
        public int BaudRate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}
