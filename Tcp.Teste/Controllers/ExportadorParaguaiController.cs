using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tcp.Teste.Api.Controllers
{
    [Route("api/pr/exportador")]
    [ApiController]
    public class ExportadorParaguaiController : ControllerBase
    {
        // GET: api/pr/exportador
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/pr/exportador/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/pr/exportador
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/pr/exportador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/pr/exportador/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
