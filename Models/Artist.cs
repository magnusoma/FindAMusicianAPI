using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FindAMusicianAPI.Models {
    public class Artist {
        [Key]
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public string Instrument { get; set; }
    }
   
}