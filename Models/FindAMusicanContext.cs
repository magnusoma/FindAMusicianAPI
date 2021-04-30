using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using FindAMusicianAPI.Models;

namespace FindAMusicianAPI.Models{

    public class FindAMusicanContext : DbContext {

        public FindAMusicanContext(DbContextOptions<FindAMusicanContext> options):base(options){}
    

        public DbSet<Artist> Artist {get; set;}
        public DbSet<Job> Job {get; set;}

            
    }
}
