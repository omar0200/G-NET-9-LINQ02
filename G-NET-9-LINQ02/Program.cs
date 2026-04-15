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
            // var result = products.TakeWhile(p =>p.price < 25).OrderBy(p => p.price);
            #endregion

            #region Q04
            //bool seafood =products.Where(p => p.Category == "Seafood").All(p => p.stock > 0);
            #endregion

            #region Q05
            //    var numbers = new[] { 3, 9, 13, 18 };
            //var result = numbers.Contains(9);
            #endregion

            #region 06
            var groups = products
    .GroupBy(p => p.Category)
    .Select(g => new {
        Category = g.Key,
        Count = g.Count()
    });
            #endregion
        }

    }
}
