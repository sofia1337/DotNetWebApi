using System.Web.Http.Cors;
using DotNetWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DotNetWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class Users : ControllerBase
    {
        private Context context = new Context();
        private DbSet<User> records;

        public Users()
        {
            this.records = this.context.Set<User>();
        }

        // GET: api/<Users>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var res = new List<String>();
            foreach (var i in this.records.AsEnumerable())
                res.Add(i.Serialize());
            return res.ToArray();
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var res = this.records.SingleOrDefault(o => o.Id == id);
            if (res == null)
            {
                return "";
            }
            return res.Serialize();
        }

        // POST api/<Users>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            this.records.Add(value);
            this.context.SaveChanges();
        }

        // POST api/<Users>
        [HttpPost("Register")]
        public string Register([FromBody] User value)
        {
            this.records.Add(value);
            this.context.SaveChanges();
            var res = this.records.SingleOrDefault(o => value.Name + value.Password == o.Name + o.Password);
            if (res == null)
            {
                return "Non registered";
            }
            return res.Serialize();
        }

        // POST api/<Users>
        [HttpPost("Auth")]
        public string Auth([FromBody] User value)
        {
            var res = this.records.SingleOrDefault(o => value.Name+value.Password == o.Name + o.Password);
            if (res == null)
            {
                return "Non registered";
            }
            return res.Serialize();
        }

        // PUT api/<Users>/5
        [HttpPut]
        public void Put([FromBody] User value)
        {
            this.records.Update(value);
            this.context.SaveChanges();
        }

        // DELETE api/<Users>/5
        [HttpDelete]
        public void Delete([FromBody] User value)
        {
            this.records.Remove(value);
            this.context.SaveChanges();
        }
    }
}
