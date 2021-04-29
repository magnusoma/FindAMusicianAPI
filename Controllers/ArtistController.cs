using FindAMusicianAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FindAMusicianAPI.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ArtistController : ControllerBase {
        
        private readonly ArtistContext _context;

        public ArtistController(ArtistContext context) {
            _context = context;
        }
        /*
        [HttpGet]
        public async Task<IEnumerable<Artist>> GetArtistList() {
            List<Artist> artistlist = await _context.Artist.ToListAsync();

            return artistlist;
        }
        */

        [HttpGet("{id}")]
        public async Task<Artist> Get(int id) {
            Artist artist = await _context.Artist.FirstAsync( _artist => _artist.ArtistID == id );
            return artist;
        }

    }
}