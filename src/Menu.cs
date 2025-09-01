using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();
        void AddDish(Dish dish) {
            dishes.Add(dish);
        }

        void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        Dish GetDishByName(string name)
        {
            return dishes.Find(dish => dish.Name == name);
        }
    }
    
}