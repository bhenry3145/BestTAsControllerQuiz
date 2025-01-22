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
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItServices _reverseItServices;

        public ReverseItController(ReverseItServices reverseItServices)
        {
            _reverseItServices = reverseItServices;
        }

        [HttpGet]
        [Route("ReverseIt/{input}")]

        public string ReverseIt(string input)
        {
            return _reverseItServices.ReverseIt(input);
        }
    }
}