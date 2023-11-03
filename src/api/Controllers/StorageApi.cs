using Microsoft.AspNetCore.Mvc;
using core;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageApi : ControllerBase
    {
        // GET: api/<StorageApi>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Moin");
        }

        // GET api/<StorageApi>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "value";
        }

        // POST api/<StorageApi>
        [HttpPost]
        public ActionResult Post([FromBody] UserData package)
        {
            try
            {
                // db.store(package)
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<StorageApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StorageApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
