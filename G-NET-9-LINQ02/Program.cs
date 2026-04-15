namespace G_NET_9_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200 },
                new Product { Name = "Smartphone", Price = 800 },
                new Product { Name = "Tablet", Price = 600 },
                new Product { Name = "Headphones", Price = 200 },
                new Product { Name = "Smartwatch", Price = 300 }
            };
            #region Q01
            //var topExpensive = products.Take(3);
            #endregion

            #region Q02
            var page = products.Skip(5).Take(5);
            #endregion

            #region Q03
            var result = products.TakeWhile(p =>p.price < 25).OrderBy(p => p.price);
            #endregion
        }
    }
}
