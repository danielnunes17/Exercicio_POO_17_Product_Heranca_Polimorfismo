
using System.Globalization;

namespace Exercicio_POO_17_Product_Heranca_Polimorfismo.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() => Name + "(used)" +
            " $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy")
            + ")";
    }
}
