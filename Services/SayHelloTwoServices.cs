using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Models;

namespace BestTAsControllerQuiz.Services
{
    public class SayHelloTwoServices
    {

        public List<SayHelloTwo> people = [
            new SayHelloTwo {personName = "Bowen"},
            new SayHelloTwo {personName = "Juan"},
            new SayHelloTwo {personName = "David"}
        ];

        public List<SayHelloTwo> AddName(SayHelloTwo nameToAdd)
        {
            people.Add(nameToAdd);
            return people;
        }
    }
}