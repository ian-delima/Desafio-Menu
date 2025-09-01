namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string name;
        private double price;
        private bool isVegetarian;
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegetarian { get; set; }

        public Dish(string name, double price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;    
        }
    }
}