using System.Net.Sockets;

namespace HelpDeskSystem.Web.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Ticket> Tickets { get; set; } = new();
    }
}
