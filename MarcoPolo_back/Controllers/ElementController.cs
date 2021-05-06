using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.Appium.Windows;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarcoPolo_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        // GET: api/<ElementController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string resp = "USAGE: api/element/id";
            yield return resp;
        }

        // GET api/<ElementController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Console.WriteLine("id: " + id);
            var selenium = new MarcoPolo_back.Mapper.ButtonMapper();
            return selenium.SendEvent(id, "click","");
        }

        // POST api/<ElementController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ElementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ElementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
