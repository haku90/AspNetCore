using System;
using Microsoft.AspNetCore.Mvc;

public class HelloWorldController : Controller
{
    [HttpGet]
    [Route("api/helloworld")]
    public object HelloWorld()
    {
        return new
        {
            message = "Hello World",
            time = DateTime.Now
        };
    }
}