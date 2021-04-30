using FindAMusicianAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FindAMusicianAPI.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase {
        
        private readonly FindAMusicanContext _context;

        public JobController(FindAMusicanContext context) {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Job>> JobList() {
            List<Job> Joblist = await _context.Job.ToListAsync();

            return Joblist;
        }
        

    }
}