using Microsoft.AspNetCore.Mvc;
[Route("Home")]

public class Home2Controller : Controller{
[Route("Index")]
 public IActionResult Index()
 {
 return Ok("This is the index of the Home controller");
 }
 [Route("Quote")]
 public IActionResult Quote()
 {
 return Ok("This is the Quote of the HomeController");
 }
}