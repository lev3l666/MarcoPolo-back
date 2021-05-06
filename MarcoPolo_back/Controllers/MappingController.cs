using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarcoPolo_back.Controllers
{
    [ApiController]
    [Route("api/start")]
    public class MappingController : ControllerBase
    {
        private readonly ILogger<MappingController> _logger;

        public MappingController(ILogger<MappingController> logger)
        {
            _logger = logger;
        }

        //api/start/route_to_vcds
        [HttpGet("{id}")]
        public Boolean Get(string id)
        {
            Console.WriteLine("Program: "+id);
            var selenium = new MarcoPolo_back.Mapper.ButtonMapper();
            return selenium.StartSession(@"C:\Ross-Tech\VCDS\VCDS.EXE");
        }
    }
}
