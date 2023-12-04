namespace TestApi.Controllers;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class HelloWorldController : Controller
{
    [HttpGet]
    public string Get() => "Hello world!";

    [HttpGet] // posso usar dessa forma ou [HttpGet("second")] - rota: /HelloWorld/second
    [Route("2")] // rota: /HelloWorld/2
    public string GetHelloTrybe() => "Hello Trybe!";
}
