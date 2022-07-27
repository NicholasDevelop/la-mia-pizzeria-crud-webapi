﻿using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        [HttpGet]
        //[Route("Get")]
        public IActionResult Get(string? search)
        {
            using(PizzeriaContext context = new PizzeriaContext())
            {
                IQueryable<Pizza> pizzas = context.Pizzas;

                if(search != null && search != ""){
                    pizzas = pizzas.Where(p => p.Name.Contains(search));
                }

                return Ok(pizzas.ToList());
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (PizzeriaContext context = new PizzeriaContext())
            {
                Pizza p = context.Pizzas.Where(p => p.Id == id).FirstOrDefault();

                if(p == null)
                {
                    return NotFound();
                }

                return Ok(p);
            }
        }
    }
}
