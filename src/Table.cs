using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        public int Number { get ; set; }
        public bool IsOccupied { get; set; }
        private List<Dish> order = new List<Dish>();

        public void Occupy()
        {
            IsOccupied = true;
        }

        public void Free()
        {
            IsOccupied = false;
        }

        public void AddToOrder(Dish)
        {
            order.Add(Dish);
        }
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}