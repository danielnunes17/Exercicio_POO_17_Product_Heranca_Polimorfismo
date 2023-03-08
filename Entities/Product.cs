using System.Globalization;

namespace Exercicio_POO_17_Product_Heranca_Polimorfismo.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
            => Name + " $ " +
            Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}
