using Aula132ExFixEnumEComposition.Entities; //Chamando a pasta Entities para utilizar outros objetos que compõe a pasta
using System.Globalization; 

namespace Aula132ExFixEnumEComposition.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        //Construtores
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        //Método para calcular o subtotal do produto vezes a quantidade desejada
        public double SubTotal()
        {
            return Price * Quantity;
        }

        //Override para converter as informações do objeto em string para podermos mostrar na tela
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                +", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
