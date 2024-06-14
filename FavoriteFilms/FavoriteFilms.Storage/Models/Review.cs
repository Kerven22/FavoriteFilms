namespace FavoriteFilms.Storage.Models
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public string Title { get; set; }

        public Guid FilimId { get; set; }
        public Filim Filim { get; set; }
    }
}
