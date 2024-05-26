using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class RoomDbContext : DbContext
    {
        public DbSet<MeetingRoomModel> MeetingRooms { get; set; } = default!;

        static RoomDbContext()
        {

        }
        public RoomDbContext(DbContextOptions<RoomDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MeetingRoomModel>(builder =>
            {
                builder.Property(x => x.NameRoom).HasMaxLength(150);
                builder.Property(x => x.PersonAge);
                builder.Property(x => x.NumberOfPeople);
                builder.Property(x => x.MaxTime);

            });
        }

    }
}
