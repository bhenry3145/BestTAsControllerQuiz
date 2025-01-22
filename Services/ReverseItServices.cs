using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsControllerQuiz.Services
{
    public class ReverseItServices
    {
        public string sentence = "";
        public string reversedWord = "";

        public string ReverseIt(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedWord += input[i];
            }
            sentence = "You entered " + input + ", reversed is " + reversedWord;
            return sentence;
        }
    }
}