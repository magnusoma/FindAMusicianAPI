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
                .Where( a => a.CustomerLastName.ToLower()
                .Contains(name.ToLower()) )
                .ToListAsync();
            return JobList;
        }
        [HttpPut]
        public async Task<Job> Put(Job job) {
            _context.Update(job);
            await _context.SaveChangesAsync();
            return job;
        }

        [HttpDelete("{id}")]
        public async Task<Job> Delete(int id) {
            Job JobToDelete = await _context.Job.FirstAsync( job => job.Id == id );
            _context.Job.Remove(JobToDelete);
            await _context.SaveChangesAsync();
            return JobToDelete;
        }

        [HttpPost]
        public async Task<Job> Post( Job newJob) {
            _context.Job.Add(newJob);
            await _context.SaveChangesAsync();
            return newJob;
        }

    }
}
