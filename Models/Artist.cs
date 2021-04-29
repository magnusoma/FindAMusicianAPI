using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FindAMusicianAPI.Models {
    public class Artist {
        [Key]
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public IList<ArtistMusicanType> ArtistMusicanType { get; set; }
    }
    public class ArtistMusicanType {
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public int MusicanTypeID { get; set; }
        public MusicanType MusicanType { get; set; }
    }

    public class MusicanType {
        public int MusicanTypeID { get; set; }
        public string Type { get; set; }
        public IList<ArtistMusicanType> ArtistMusicanType { get; set; }
    } 
}

/*

Artist

Artist_ID {PK}
Name
Price
Image
Bio
UpVote
DownVote

Artist-Musican-Type

ID {Pk, FK}
MT-ID {PK, FK}

Musician-Type

ID {PK}
Type 

*/