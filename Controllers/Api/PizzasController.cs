using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/pizzas")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        [HttpGet]
        //[Route("Get")]
        public IActionResult Get()
        {
            using(PizzeriaContext context = new PizzeriaContext())
            {
                List<Pizza> pizzaList = context.Pizzas.ToList();
                return Ok(pizzaList);
            }
        }
    }
}
