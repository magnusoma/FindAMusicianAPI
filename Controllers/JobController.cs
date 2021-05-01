using FindAMusicianAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

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
        
        [HttpGet("{id}")]
        public async Task<Job> Get(int Id) {
            return await _context.Job.FirstAsync( Job => Job.Id == Id);
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<IEnumerable<Job>> GetByName(string name) {
            List<Job> JobList = await _context.Job
                .Where( a => a.JobName.ToLower()
                .Contains(name.ToLower()) )
                .ToListAsync();
            return JobList;
        }

        [HttpPost]
        public async Task<Job> Post( Job newJob) {
            _context.Job.Add(newJob);
            await _context.SaveChangesAsync();
            return newJob;
        }

    }
}