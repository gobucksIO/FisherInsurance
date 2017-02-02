using Microsoft.AspNetCore.Mvc;

public class Home2Controller : Controller{

 public IActionResult Index()
 {
 return Ok("This is the index of the home2");
 }
 
 public IActionResult Quote()
 {
 return Ok("This is the Quote of the LifeController");
 }
}