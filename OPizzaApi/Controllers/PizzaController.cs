using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPizzaApi.Data;
using OPizzaApi.Model;

namespace OPizzaApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : Controller
    {
        private readonly PizzaDbContext _context;
        public PizzaController(PizzaDbContext db)
        {
            _context = db;
        }

        [HttpPost]
        public async Task<IActionResult> AddPizza(Pizza model)
        {

            if (model.Data == null || model.Data.Length == 0)
            {
                // Handle the case where image data is missing or empty
                return BadRequest("Image data is required.");
            }

            await _context.pizzas.AddAsync(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllPizzas()
        {
            return Ok(await _context.pizzas.ToListAsync());
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Pizza([FromRoute] int id)
        {
            var pizza = await _context.pizzas.FindAsync(id);
            if(pizza != null)
            {
                return Ok(pizza);
            }
            
            return NotFound();
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeletePizza([FromRoute] int id)
        {
            var pizza = await _context.pizzas.FindAsync(id);
            if (pizza != null)
            {
                _context.pizzas.Remove(pizza);
                _context.SaveChanges();
                return Ok(pizza);
            }

            return NotFound();
        }


        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> EditPizza([FromRoute] int id , Pizza edit)
        {
            var pizza = await _context.pizzas.FindAsync(id);
            if (pizza != null)
            {
                pizza.FinalPrice = edit.FinalPrice;
                pizza.PizzaName = edit.PizzaName;
                pizza.Mushrooms = edit.Mushrooms;
                pizza.Anchovies = edit.Anchovies;
                pizza.Bacon=edit.Bacon;
                pizza.CheeseType=edit.CheeseType;
                pizza.Description=edit.Description;
                pizza.Ham=edit.Ham;
                pizza.Olives=edit.Olives;
                pizza.GreenPeppers=edit.GreenPeppers;
                pizza.TomatoSauce=edit.TomatoSauce;
                pizza.Pineapple=edit.Pineapple;
                pizza.Pepperoni=edit.Pepperoni;
                pizza.Onions=edit.Onions;
                pizza.Data  = edit.Data;

                _context.SaveChanges();
                return Ok(pizza);
            }

            return NotFound();
        }

    }
}
