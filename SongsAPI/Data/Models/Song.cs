namespace SongsAPI.Data.Models
{
    public class Song
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Category { get; set; }
        public string? Album { get; set; }
        public string Singer { get; set; }
        public DateTime? Release { get; set; }
       // public string SongNumber { get; set; }

    }
}
