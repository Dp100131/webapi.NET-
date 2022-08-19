using Microsoft.AspNetCore.Mvc;
using webAPIapi.Interfaces;

namespace webAPIapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController: ControllerBase
    {
        private readonly ILogger<HelloWorldController> _Logger;

        HelloWorldInterface helloworldService;

        public HelloWorldController(HelloWorldInterface helloWorldService, ILogger<HelloWorldController> logger)
        {
            this.helloworldService = helloWorldService;
            _Logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _Logger.LogInformation("Retornando Hello World");
            return Ok(helloworldService.GetHelloWorld());
        }

    }
}