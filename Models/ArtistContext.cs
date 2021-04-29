using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FindAMusicianAPI.Models{

    public class ArtistContext : DbContext {

        public ArtistContext(DbContextOptions<ArtistContext> options):base(options){}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ArtistMusicanType>()
                .HasKey(amt => new { amt.ArtistID, amt.MusicanTypeID });
            
            modelBuilder.Entity<ArtistMusicanType>()
                .HasOne<Artist>(amt => amt.Artist)
                .WithMany(a => a.ArtistMusicanType)
                .HasForeignKey(amt => amt.ArtistID);

            modelBuilder.Entity<ArtistMusicanType>()
                .HasOne<MusicanType>(amt => amt.MusicanType)
                .WithMany(mt => mt.ArtistMusicanType)
                .HasForeignKey(amt => amt.MusicanTypeID);
        }    

        public DbSet<FindAMusicianAPI.Models.Artist> Artist {get; set;}
        public DbSet<FindAMusicianAPI.Models.ArtistMusicanType> ArtistMusicanType {get; set;}
        public DbSet<FindAMusicianAPI.Models.MusicanType> MusicanType {get; set;}

            
    }
}

/*
.HasOne<Artist>(ArtistMusicanType => amt.Artist)
.WithMany(Artist => Artist.ArtistMusicanType)
.HasForeignKey(amt)

modelBuilder.Entity<StudentCourse>()
    .HasOne<Student>(sc => sc.Student)
    .WithMany(s => s.StudentCourses)
    .HasForeignKey(sc => sc.SId);


modelBuilder.Entity<StudentCourse>()
    .HasOne<Course>(sc => sc.Course)
    .WithMany(s => s.StudentCourses)
    .HasForeignKey(sc => sc.CId);
*/