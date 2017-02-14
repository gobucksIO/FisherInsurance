using System;
using System.Collections.Generic;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;
 
[Route("claim")]
public class CustomerCareController : Controller
{
    [RouteAttribute("")]
    [RouteAttribute("index")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return View();
    }
    
    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
       // List<Claim> claims = new List<Claim>();
        //claims.Add(new Claim{Id=1, PolicyNumber= "RTY777790", LossDate=DateTime.Now.AddDays(-16), LossAmount = 4200M, Status="Open"});
        //claims.Add(new Claim{Id=1, PolicyNumber= "RTY575870", LossDate=DateTime.Now.AddDays(-250), LossAmount = 10000M, Status="Closed"});
        //claims.Add(new Claim{Id=1, PolicyNumber= "RTY575870", LossDate=DateTime.Now.AddDays(-250), LossAmount = 4200M, Status="Denied"});
        //claims.Add(new Claim{Id=1, PolicyNumber= "RTY123790", LossDate=DateTime.Now.AddDays(-1000), LossAmount = 5000M, Status="Closed"});
        
        return View();
    }
}