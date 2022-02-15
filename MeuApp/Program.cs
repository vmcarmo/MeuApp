using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Gamer", 55.87, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção Eletrica Residencial", 55.90, EProductType.Service);

            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}