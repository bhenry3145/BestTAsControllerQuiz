using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsControllerQuiz.Services
{
    public class SayHelloServices
    {
        public string sentence = "";
        public string SayHello(string sayHelloTo)
        {
            sentence = "Hello, " + sayHelloTo + ".";
            return sentence;
        }
    }
}