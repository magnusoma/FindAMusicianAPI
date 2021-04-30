using System.ComponentModel.DataAnnotations;

namespace FindAMusicianAPI.Models {

    
    public class Job {
        [Key]
        public int Id { get; set; } //Primary Key
        public string JobName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerTlf { get; set; }
        public string CustomerEmail { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
        public string JobAddress { get; set; }
        public bool isFinished { get; set; }
    }
}