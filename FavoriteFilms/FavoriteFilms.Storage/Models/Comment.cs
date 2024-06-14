namespace FavoriteFilms.Storage.Models
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid FilimId { get; set; }
        public Filim Filim { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
