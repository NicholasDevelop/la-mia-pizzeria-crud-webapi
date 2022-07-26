using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/pizzas")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using(PizzeriaContext context = new PizzeriaContext())
            {
                List<Pizza> pizzaList = context.Pizzas.ToList();
                //IQueryable<Pizza> pizzaList = (IQueryable<Pizza>)ctx.Pizzas.ToList<Pizza>();
                return Ok(pizzaList);
            }
        }
    }
}
