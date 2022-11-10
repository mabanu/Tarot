using Microsoft.AspNetCore.Mvc;

namespace TarotApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TarotController : Controller
{
	// GET
	public IActionResult Index()
	{
		return View();
	}
}