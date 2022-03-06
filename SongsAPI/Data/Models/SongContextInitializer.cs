namespace SongsAPI.Data.Models
{
    public class SongContextInitializer
    {
        public static void Seed(IApplicationBuilder appbuilder)
        {
            using (var serviceScope = appbuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SongDbContext>();
                if (!context.Songs.Any()) {
                    context.Songs.AddRange(
                        new Song()
                        {
                            Name = "The Hills",
                            Category = "pop",
                            Album = "Beauty Behind The Madness",
                            Singer = "Weeknd",
                            Release = new DateTime(2015 - 05 - 27)
                        },

                        new Song()
                        {
                            Name = "RadioActive",
                            Category = "electronic rock",
                            Singer = "Band(Imagine Dragons)",
                            Album = "EP Continued Silence",
                            Release = new DateTime(2013 - 04 - 09)
                        });
                    context.SaveChanges();
                }
            }
        }
    }
}
