using Microsoft.EntityFrameworkCore;
using CreekRiver.Models;

public class CreekRiverDbContext : DbContext
{

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }

        public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Campsite>().HasData(new Campsite[]
        {
        new Campsite {Id = 1, CampsiteTypeId = 1, Nickname = "Barred Owl", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
        new Campsite {Id = 2, CampsiteTypeId = 1, Nickname = "Red Fox", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site74.jpg"},
        new Campsite {Id = 3, CampsiteTypeId = 2, Nickname = "White Oak", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site75.jpg"},
        new Campsite {Id = 4, CampsiteTypeId = 1, Nickname = "Blue Heron", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site76.jpg"},
        new Campsite {Id = 5, CampsiteTypeId = 3, Nickname = "Golden Eagle", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site77.jpg"},
        new Campsite {Id = 6, CampsiteTypeId = 2, Nickname = "River Birch", ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site78.jpg"}
        });    
        // seed data with campsite types
        modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[]
        {
            new CampsiteType {Id = 1, CampsiteTypeName = "Tent", FeePerNight = 15.99M, MaxReservationDays = 7},
            new CampsiteType {Id = 2, CampsiteTypeName = "RV", FeePerNight = 26.50M, MaxReservationDays = 14},
            new CampsiteType {Id = 3, CampsiteTypeName = "Primitive", FeePerNight = 10.00M, MaxReservationDays = 3},
            new CampsiteType {Id = 4, CampsiteTypeName = "Hammock", FeePerNight = 12M, MaxReservationDays = 7}
        });

        modelBuilder.Entity<Reservation>().HasData(new Reservation[]
        {
            new Reservation {Id = 1, CampsiteId = 1, UserProfileId = 1, CheckinDate = new DateTime(2025, 3, 15), CheckoutDate = new DateTime(2025, 3, 18)}
        });
        

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new UserProfile {Id = 1, FirstName = "Noah", LastName = "Allen", Email = "noahsux@gmail.com"}
        });
    }
}
