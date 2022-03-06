namespace SongsAPI.Data.Models
{
    public class SongVM
    {
        public string Name { get; set; }
        public string Album { get; set; }
        public string Singer { get; set; }
        public string? Category { get; set; }
       
    }

    public class SongVMEdit
    {
        public string Name { get; set; }
        public string? Category { get; set; }
        public string Album { get; set; }
        public DateTime? Release { get; set; }
    }
}
