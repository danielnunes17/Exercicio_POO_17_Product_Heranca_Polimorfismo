using Exercicio_POO_17_Product_Heranca_Polimorfismo.Entities;
using System.Globalization;

namespace Exercicio_POO_17_Product_Heranca_Polimorfismo
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported? (c/u/i): ");
                char typeProduct = char.Parse(Console.ReadLine());
                if (typeProduct == 'c')
                {
                    products.Add(CreatUsedProductCommum());
                }
                else if (typeProduct == 'u')
                {
                    products.Add(CreatUsedProduct());
                }
                else
                {
                    products.Add(CreatProductImported());
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }

        private static Product CreatProductImported()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Customs fee: ");
            double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new ImportedProduct(name, price, customs);
        }

        private static Product CreatUsedProduct()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Manufacture date(DD / MM / YYYY): ");
            DateTime manufacture = DateTime.Parse(Console.ReadLine());

            return new UsedProduct(name, price, manufacture);
        }
        private static Product CreatUsedProductCommum()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Product(name, price);
        }
    }
}