using FindAMusicianAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FindAMusicianAPI.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ArtistController : ControllerBase {
        
        private readonly FindAMusicanContext _context;

        public ArtistController(FindAMusicanContext context) {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Artist>> GetArtistList() {
            List<Artist> artistlist = await _context.Artist.ToListAsync();

            return artistlist;
        }
        

    }
}