using Microsoft.AspNetCore.Mvc;

namespace M3_03_WEB_API.Controllers;

[ApiController]
[Route("api/fruits")]
public class FruitController : Controller
{
    private static List<string> Fruits = new List<string> { "Apple", "Orange", "Banana", "Mango" };
    
    [HttpGet]
    public IActionResult GetFruits()
    {
        return Ok(Fruits);
    }
    
    [HttpGet("{index}")]
    public IActionResult GetFruit(int index)
    {
        if (index < 0 || index >= Fruits.Count)
        {
            return NotFound(); // Return 404 Not Found if the index is out of range.
        }
        return Ok(Fruits[index]);
    }
    
    [HttpGet("random")]
    public IActionResult GetRandomFruit()
    {
        return Ok(Fruits[new Random().Next(0, Fruits.Count)]);
    }
    
    [HttpPost]
    public IActionResult AddFruit([FromBody] string fruit)
    {
        if (string.IsNullOrWhiteSpace(fruit))
        {
            return BadRequest("Fruit should not be empty or whitespace.");
        }

        Fruits.Add(fruit);
        return Ok(fruit);
    }
}