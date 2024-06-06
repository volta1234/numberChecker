using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TaskApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : Controller
    {
        // 1. Palindrome Checker
        [HttpGet("IsPalindrome")]
        public ActionResult<bool> IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return BadRequest("Input cannot be null or empty");
            var reversed = new string(input.Reverse().ToArray());
            return Ok(input == reversed);
        }

        // 2. FizzBuzz
        [HttpGet("FizzBuzz")]
        public ActionResult<IEnumerable<string>> FizzBuzz()
        {
            var result = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) result.Add("FizzBuzz");
                else if (i % 3 == 0) result.Add("Fizz");
                else if (i % 5 == 0) result.Add("Buzz");
                else result.Add(i.ToString());
            }
            return Ok(result);

            return View(); 
        }

        // 3. Find the largest number in a list
        [HttpPost("LargestNumber")]
        public ActionResult<int> LargestNumber([FromBody] List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0) return BadRequest("List cannot be null or empty");
            return Ok(numbers.Max());
        }

        // 4. Reverse a string
        [HttpGet("ReverseString")]
        public ActionResult<string> ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return BadRequest("Input cannot be null or empty");
            var reversed = new string(input.Reverse().ToArray());
            return Ok(reversed);
        }
    }
}
