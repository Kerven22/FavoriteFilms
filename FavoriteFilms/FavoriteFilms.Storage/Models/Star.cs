namespace FavoriteFilms.Storage.Models
{
    public class Star
    {
        public Guid ActorId { get; set; }
        public string Login { get; set; }
        public string Country { get; set; }
        public DateTimeOffset DateBirthDay { get; set; }

        public ICollection<Filim> Filims { get; set; }
    }
}
