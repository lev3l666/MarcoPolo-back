using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarcoPolo_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase
    {
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EventsController>/"C:\Ross-Tech\VCDS\VCDS.EXE"/
        [HttpGet("{id}")]
        public IEnumerable<WindowsControl> Get(string id)
        {
            //EXAMPLE FOR VCDS: app=@"C:\Ross-Tech\VCDS\VCDS.EXE", parent=".//*[@ClassName='#32770']/child:: * "
            Console.WriteLine("id: "+id);
            var selenium = new MarcoPolo_back.Mapper.ButtonMapper();
            return selenium.GetAllControlsXpath(".//*[@ClassName='#32770']/descendant:: * ");
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
