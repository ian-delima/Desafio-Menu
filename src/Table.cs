using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private int number;
        private bool isOccupied;
        public int Number { get ; set; }
        public bool IsOccupied { get; set; }
        private List<Dish> order = new List<Dish>();

        public Table(int number)
        {
            this.Number = number;
        }

        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
        }

        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}