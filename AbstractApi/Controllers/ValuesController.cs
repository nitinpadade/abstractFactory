using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractLayer;
using AbstractLayer.Client;
using AbstractLayer.Command;
using AbstractLayer.Factory;
using AbstractLayer.Model;
using AbstractLayer.Parameter;
using AbstractLayer.Query;
using Microsoft.AspNetCore.Mvc;

namespace AbstractApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : BaseController
    { 
        public ValuesController(ICommandHandler command, IQueryExecutor query)
            : base(command, query)
            
        {          

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var result = Command<UserCommand, User>(new User { Id = 1, Name = "Devansh" });
            return new string[] { result.Message };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = Query<UserQuery, User, UserParameter>(new UserParameter { Id = id });
            return Ok(result);
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
