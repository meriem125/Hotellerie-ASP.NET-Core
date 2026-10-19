using Microsoft.EntityFrameworkCore;

namespace HotellerieMariem.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public DbSet<HotellerieMariem.Models.HotellerieModel.Appreciation> Appreciations { get; set; } = default!;
        public HotellerieDbContext(DbContextOptions<HotellerieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}