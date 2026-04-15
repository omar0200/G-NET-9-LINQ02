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
            //        var groups = products
            //.GroupBy(p => p.Category)
            //.Select(g => new {
            //    Category = g.Key,
            //    Count = g.Count()
            //});
            #endregion

            #region Q 07
            //        var result = products
            //.GroupBy(p => p.Category)
            //.Select(g => new {
            //    Category = g.Key,
            //    Names = g.Select(p => p.ProductName)
            //});
            //    }
            #endregion

            #region Q08
            //        var categories = products
            //.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);
            #endregion

            #region Q09
            //        var result =
            //from c in customers
            //group c by c.Country into g
            //select new
            //{
            //    Country = g.Key,
            //    Count = g.Count(),
            //    TotalOrderValue = g.Sum(x => x.Orders.Sum(o => o.Total))
            //};
            #endregion

            #region Q10
            //int total = products.Sum(p => p.UnitsInStock);
            #endregion

            #region Q11
            //var min = products.Min(p => p.UnitPrice);
            //var max = products.Max(p => p.UnitPrice);
            #endregion

            #region Q12
            //        var categories = products
            //.Select(p => p.Category)
            //.Distinct();
            #endregion

            #region Q13 
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);
            #endregion

            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1
            //    .Where(c => !list2.Any(x => x.Equals(c, StringComparison.OrdinalIgnoreCase)));
            #endregion

            #region Q15 
            //var dict = products.ToDictionary(p => p.ProductID);

            //var product18 = dict[18];
            #endregion

            #region Q16
            //var product = products.First(p => p.UnitPrice > 50);
            #endregion

            #region Q17 
            //var product = products.FirstOrDefault(p => p.UnitPrice > 500);
            #endregion

            #region Q18
            //        var table = Enumerable.Range(1, 10)
            //.Select(x => 7 * x);
            #endregion

            #region Q19
            //        var evens = Enumerable.Range(1, 30)
            //.Where(x => x % 2 == 0);
            #endregion

            #region Q20
            var result = products.Take(3).Select(p => p.ProductName)
    .Concat(customers.Take(3).Select(c => c.CompanyName));
            #endregion
        }
    }

}