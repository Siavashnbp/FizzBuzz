using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Api.Controllers
{
    [ApiController]
    [Route("api/FizzBuzz")]
    public class FizzBuzzController : ControllerBase
    {
        [HttpPost]
        public void CheckFizzBuzz(string input)
    }
}
