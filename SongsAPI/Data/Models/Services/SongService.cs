namespace SongsAPI.Data.Models.Services
{
    public class SongService
    {
        private SongDbContext _context;
        public SongService(SongDbContext context)
        {
                _context = context; 
        }

        public void AddSong(SongVM song)
        {
            var _song = new Song();
            if(song!= null)
            {
                _song.Name = song.Name;
                _song.Album = song.Album;
                _song.Singer = song.Singer;
                _song.Category = song.Category;
                _context.Songs.Add(_song);
                _context.SaveChanges();

            }
        }

        public List<Song> GetAllSongData()=> _context.Songs.ToList();

       // public Song GetSongByName(string name)=> _context.Songs.FirstOrDefault(s=>s.Name.Contains(name));
        public Song GetSongByID(int id) => _context.Songs.FirstOrDefault(s=>s.Id == id);

        public Song UpdateSongDetails(SongVMEdit song,int id)
        {
            var _song = _context.Songs.FirstOrDefault(s=>s.Id == id);
            if(song != null)
            {
               
                _song.Name = song.Name;                ;
                _song.Album= song.Album;
                _song.Release = song.Release;
                _song.Category = song.Category;

                _context.SaveChanges();
            }
            return _song;
        }

        public void DeletSongById(int id)
        {
            var _song = _context.Songs.FirstOrDefault(s => s.Id == id);
            _context.Songs.Remove(_song);
            _context.SaveChanges();
        }
       

    }
}
