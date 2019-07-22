using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> GetAll()
        {
            using (ToDoContext cntext = new ToDoContext())
            {
                cntext.Database.EnsureCreated();
                return cntext.User.ToList();
            }

            
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<UserModel> Get(int id)
        {
            using (ToDoContext cntext = new ToDoContext())
            {
                cntext.Database.EnsureCreated();
                return cntext.User.First(s => s.id == id);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
