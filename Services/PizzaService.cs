using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class PizzaService
    {
        static List<MPizza> Pizzas { get; }
        static int id = 3;
        static PizzaService()
        {
            Pizzas = new List<MPizza>
            {
                new MPizza {Id = 1, Name = "Peperoni", Price = 20.0M, Size = PizzaSize.Medium, IsGlutenFree = false},
                new MPizza {Id = 2, Name = "Margarita", Price = 25.0M, Size = PizzaSize.Medium, IsGlutenFree = false}
            };   
            
        }
        public static List<MPizza> GetAll() => Pizzas;
        public static MPizza? Get(int id) => Pizzas.FirstOrDefault(x => x.Id == id);
        public static void Add(MPizza pizza)
        {
            pizza.Id = ++id;
            Pizzas.Add(pizza);
        }
        public static void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza != null)
            {
                Pizzas.Remove(pizza);
            }
            
        }
        public static void Update(MPizza p)
        {
            var index = Pizzas.FindIndex(x => x.Id == p.Id);
            if (index == -1)return;
            Pizzas[index] = p;
        }
    }
}
