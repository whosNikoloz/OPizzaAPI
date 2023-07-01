using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPizzaApi.Data;
using OPizzaApi.Model;

namespace OPizzaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly PizzaDbContext _context;
        public OrderController(PizzaDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Orders()
        {
            return Ok(await _context.orders.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Order([FromRoute] int id)
        {
            var order = await _context.orders.FindAsync(id);

            return Ok(order);
        }


        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            if(order != null)
            {
                await _context.orders.AddAsync(order);
                await _context.SaveChangesAsync();
            }

            return Ok(order);
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] int id)
        {
            var order = await _context.orders.FindAsync(id);
            if(order != null)
            {
                _context.orders.Remove(order);
                _context.SaveChanges();
            }

            return Ok("Removed Order");
        }

    }
}
