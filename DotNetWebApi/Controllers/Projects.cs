using DotNetWebApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetWebApi.Controllers
{
    [EnableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class Projects : ControllerBase
    {
        private Context context = new Context();
        private DbSet<Project> records;

        public Projects() 
        {
            this.records = this.context.Set<Project>();
        }

        // GET: api/<Projects>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var res = new List<String>();
            foreach (var i in this.records.AsEnumerable())
                res.Add(i.Serialize());
            return res.ToArray();
        }

        // GET api/<Projects>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {   
            var res = this.records.SingleOrDefault(o => o.Id == id);
            if(res == null)
            {
                return "";
            }
            return res.Serialize();
        }

        // POST api/<Projects>
        [HttpPost]
        public void Post([FromBody] Project value)
        {
            Console.WriteLine(value.Serialize());
            this.records.Add(value);
            this.context.SaveChanges();
        }

        // PUT api/<Projects>/5
        [HttpPut]
        public void Put([FromBody] Project value)
        {
            this.records.Update(value);
            this.context.SaveChanges();
        }

        // DELETE api/<Projects>/5
        [HttpDelete]
        public void Delete(Project value)
        {
            this.records.Remove(value);
            this.context.SaveChanges();
        }
    }
}
