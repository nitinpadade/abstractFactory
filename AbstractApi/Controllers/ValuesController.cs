using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractLayer;
using AbstractLayer.Client;
using AbstractLayer.Command;
using AbstractLayer.Factory;
using AbstractLayer.Model;
using Microsoft.AspNetCore.Mvc;

namespace AbstractApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly ICommandHandler _command;
       
        public ValuesController(ICommandHandler command)
        {
            _command = command;

        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var result = _command.Dispatch<UserCommand, User>(new User { Id = 1, Name = "Devansh" });
            return new string[] { result.Message };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
