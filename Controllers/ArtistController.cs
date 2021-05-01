using FindAMusicianAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace FindAMusicianAPI.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ArtistController : ControllerBase {
        
        private readonly FindAMusicanContext _context;

        private readonly IWebHostEnvironment _hosting;

        public ArtistController(FindAMusicanContext context, IWebHostEnvironment hosting) {
            _context = context;
            _hosting = hosting;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Artist>> GetArtistList() {
            List<Artist> artistlist = await _context.Artist.ToListAsync();
            return artistlist;
        }

        [HttpGet("{id}")]
        public async Task<Artist> Get(int Id) {
            return await _context.Artist.FirstAsync( Artist => Artist.ArtistId == Id);
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<IEnumerable<Artist>> GetByName(string name) {
            List<Artist> artistList = await _context.Artist
                .Where( a => a.ArtistName.ToLower()
                .Contains(name.ToLower()) )
                .ToListAsync();
            return artistList;
        }

        [HttpPost]
        public async Task<Artist> Post( Artist newArtist) {
            _context.Artist.Add(newArtist);
            await _context.SaveChangesAsync();
            return newArtist;
        }

        [HttpPost]
        [Route("[action]")]
        public void SaveImage(IFormFile file) {
            string webrootpath = _hosting.WebRootPath;
            string absolutepath = Path.Combine($"{webrootpath}/images/{file.FileName}");
            using (var filestream = new FileStream(absolutepath, FileMode.Create)) { file.CopyTo(filestream); }
        }
        

    }
}