using System.Globalization;

namespace Exercicio_POO_17_Product_Heranca_Polimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice() => CustomsFee + Price;

        public override string PriceTag() => Name + " $ " +
           TotalPrice().ToString("F2", CultureInfo.InvariantCulture) +
            " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
    }
}
