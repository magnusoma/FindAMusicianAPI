using System.ComponentModel.DataAnnotations;

namespace FindAMusician.Models {
    public class Artist {
        [Key]
        public int ArtistID { get; set; }
    } 
}