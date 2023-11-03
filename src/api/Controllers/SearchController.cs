using core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Services;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        // GET: api/<SearchController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SearchController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SearchController>
        [HttpPost]
        public List<SearchResponse> PostSearch([FromBody] SearchRequest searchRequest)
        {
            string searchthis = searchRequest.SearchBar;



            List<SearchResponse> responseList = new List<SearchResponse>();
            //SearchRequest searchRequest1 = new SearchRequest();
            //var searchRequest1 = searchRequest;
            SearchResponse response = new SearchResponse(
                "RedBull Apple",
                "HSS123456789",
                22
                );

            responseList.Add(response);
            responseList.Add(response);
            responseList.Add(response);
            responseList.Add(response);
            responseList.Add(response);



            return responseList;
        }

        // PUT api/<SearchController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SearchController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
