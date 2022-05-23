using Microsoft.EntityFrameworkCore;
using teste_mysql_do_zero.Models.Entities;

namespace teste_mysql_do_zero.Contexts
{
    public class BancoAnimeContext : DbContext
    {
        public BancoAnimeContext(DbContextOptions<BancoAnimeContext> options) : base(options)
        {
        }

        public DbSet<AnimeEntity> Animes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimeEntity>().ToTable("Anime");
        }
    }
}