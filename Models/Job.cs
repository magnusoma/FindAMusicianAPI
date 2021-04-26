using System.ComponentModel.DataAnnotations;

namespace FindAMusician.Models {

    public class Genre {
        [Key]
        public int GenreId { get; set; }
        public string GenreType { get; set; } 
    }
    public class Job {
        [Key]
        public int Id { get; set; } //Primary Key
        public string JobName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerTlf { get; set; }
        public string CustomerEmail { get; set; }
        public string Description { get; set; }

        public int? GenreId { get; set; } //Foregin Key
        public Genre Genre { get; set; } //Referance

        public string Price { get; set; }
        public string JobAddress { get; set; }
        public bool isFinished { get; set; }
    }
}
//HARD