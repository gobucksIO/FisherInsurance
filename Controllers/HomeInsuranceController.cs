using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;
[Route("Home")]

public class HomeInsuranceController : Controller{
[Route("index")]
 public IActionResult Index()
 {
 //return Ok("This is the index of the Home Insurance controller");
 return View();
 }
 [Route("quote")]
 public IActionResult Quote()
 {
      Quote quote = new Quote {  
            Id = 345,
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 12.00M        };

 return View(quote);
 //return Ok("This is the Quote of the HomeController");
 }
}