using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;

        public SayHelloController(SayHelloServices sayHelloServices)
        {
            _sayHelloServices = sayHelloServices;
        }

        [HttpPost]
        [Route("SayHello/{sayHelloTo}")]

        public string SayHello(string sayHelloTo)
        {
            return _sayHelloServices.SayHello(sayHelloTo);
        }
    }
}