using la_mia_pizzeria_static.Data;

namespace la_mia_pizzeria_static.Models.Repositories
{
    public class DbPizzaRepository
    {
        private readonly PizzeriaContext _context;
        public DbPizzaRepository()
        {
            this._context = new PizzeriaContext();
        }



        public Pizza GetById(int id)
        {

            Pizza pizzaFound = _context.Pizza.Where(p => p.Id == id).Include(p => p.Category).Include(p => p.Ingredients).FirstOrDefault();
            return pizzaFound;

        }

        public List<Pizza> GetList()
        {
            return _context.Pizza.ToList();
        }
    }
}
