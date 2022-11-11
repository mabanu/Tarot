using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarotApi.Context;
using TarotApi.Models;

namespace TarotApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TarotController : Controller
{
	private readonly MyDbContext _context;

	public TarotController(MyDbContext context)
	{
		_context = context;
	}
	// GET
	[HttpGet]
	public ActionResult<Card> GetCard()
	{
		var id = new Random().Next(1, 5);
		using var context = new MyDbContext();
		var card = context.Cards.First(data => data.Id == id);
		return card;
	}
}