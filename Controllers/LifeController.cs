using Microsoft.AspNetCore.Mvc;
public class LifeController : Controller
{
 public IActionResult Index()
 {
 //return Ok("This is the index of the LifeController");

 return View();
 }
 
 public IActionResult Quote()
 {
 return Ok("This is the Quote of the LifeController");
 }
}