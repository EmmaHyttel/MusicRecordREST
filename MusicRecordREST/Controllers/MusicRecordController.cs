using Microsoft.AspNetCore.Mvc;
using MusicRecordsRepository;
using MusicRecordsRepository.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicRecordREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordController : ControllerBase
    {
        private readonly MusicRecordRepo _repo; 

        public MusicRecordController(MusicRecordRepo repo)
        {
            _repo = repo;
        }
        // GET: api/<MusicRecordController>
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return _repo.Get();
        }

        // GET api/<MusicRecordController>/5
        [HttpGet("{id}")]
        public MusicRecord Get(int id)
        {
            return _repo.GetById(id); 
        }

        // POST api/<MusicRecordController>
        [HttpPost]
        public MusicRecord Post([FromBody] MusicRecord value)
        {
            return _repo.Add(value);
        }

        // PUT api/<MusicRecordController>/5
        [HttpPut("{id}")]
        public MusicRecord Put(int id, [FromBody] MusicRecord value)
        {
            return _repo.Update(id, value);
        }

        // DELETE api/<MusicRecordController>/5
        [HttpDelete("{id}")]
        public MusicRecord Delete(int id)
        {
            return _repo.Remove(id); 
        }
    }
}
