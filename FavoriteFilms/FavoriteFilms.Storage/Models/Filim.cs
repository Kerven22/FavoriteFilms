namespace FavoriteFilms.Storage.Models
{
    public class Filim
    {
        public Guid FilimId { get; set; }
        public string Title { get; set; }
        public DateTimeOffset PutedOnSide { get; set; }
        public int Duration { get; set; }    //продолжителность
        public int Quality { get; set; }    //качество
        public string UrlFilim { get; set; }
        public bool Serial { get; set; }
        public Review Review { get; set; }

        public ICollection<Genre> Genres { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Star> Stars { get; set; }

    }
}
