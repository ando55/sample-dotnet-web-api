using Microsoft.EntityFrameworkCore;
using SongsAPI.Data.Models;

namespace SongsAPI.Data
{
    public class SongDbContext:DbContext
    {
        public SongDbContext(DbContextOptions<SongDbContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
    }
}
