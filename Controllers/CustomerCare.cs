using Microsoft.AspNetCore.Mvc;

[Route("customer")]
public class CustomerCareController : Controller
{
 public IActionResult Index()
 {
 return Ok("This is the index of the CustomerCareController");
 }
 [Route("fileclaim")]
 public IActionResult NewClaim()
 {
 return Ok("This is the Claim of the CustomerCareController");
 }
 [Route("claimstatus")]
 public IActionResult ClaimHistory()
 {
 return Ok("This is the Claim History of the CustomerCareController");
 }
 
}