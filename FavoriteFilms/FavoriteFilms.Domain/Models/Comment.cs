using Microsoft.Identity.Client;

namespace FavoriteFilims.Domain.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string Author { get; set; }
    }
}
