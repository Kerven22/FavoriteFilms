namespace FavoriteFilms.Storage.Models
{
    public class Like
    {
        public Guid LikeId { get; set; }
        public Guid FilimId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public bool DesLike { get; set; }

        public Filim Filim { get; set; }
        public Guid UserId { get; set; }
        public User Author { get; set; }

    }
}
