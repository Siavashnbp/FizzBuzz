using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Services.FizzBuzz.Contracts;
using FizzBuzz.Services.FizzBuzz.Contracts.Exceptions;

namespace FizzBuzz.Services
{
    public class FizzBuzzAppServices : FizzBuzzServices
    {
        public bool CheckBuzz(int num)
        {
            return num % 5 == 0;
        }

        public bool CheckFizz(int num)
        {
            return num % 3 == 0;
        }

        public int GetInt(string input)
        {
            var isValid = int.TryParse(input, out var value);
            if (!isValid)
            {
                throw new InvalidIntInputException();
            }
            return value;
        }

        public string PrintResult(bool isFizz, bool isBuzz)
        {
            if (isFizz)
            {
                if (isBuzz)
                {
                    return "FizzBuzz";
                }
                return "Fizz";
            }
            else if (isBuzz)
            {
                return "Buzz";
            }
            return string.Empty;
        }
    }
}
