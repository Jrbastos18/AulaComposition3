namespace Aula132ExFixEnumEComposition.Entities
{
    internal class Product
    {
        //Propriedades do objeto Produto
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtores
        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
