using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Models;
using BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloTwoController : ControllerBase
    {
        private readonly SayHelloTwoServices _sayHelloTwoServices;

        public SayHelloTwoController(SayHelloTwoServices sayHelloTwoServices)
        {
            _sayHelloTwoServices = sayHelloTwoServices;
        }

        [HttpPost]
        [Route("AddName")]

        public List<SayHelloTwo> AddName(SayHelloTwo nameToAdd)
        {
            return _sayHelloTwoServices.AddName(nameToAdd);
        }

        
    }
}