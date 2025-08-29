using ConsoleApp1.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators
            //1
            //var result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2
            //var result2 = ListGenerator.ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3);

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Select((name, index) => new { Name = name, Index = index })
            //    .Where(x => x.Name.Length < x.Index)
            //    .Select(x => x.Index);

            //Console.WriteLine("Digits whose name length is shorter than their value:");
            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}


            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            //var result = ListGenerator.ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result2 = ListGenerator.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result2);
            #endregion
            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result3 = Arr.Where(n => n > 5).Skip(1).First();
            //Console.WriteLine(result3);



            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(result);


            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var result = ListGenerator.CustomerList.Select (c => new
            //    {
            //        c.CustomerID,
            //        OrderCount = c.Orders.Count()
            //    });

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var result = ListGenerator.ProductList.GroupBy(p => p.Category).Select(g => new
            //                                                                       {
            //                                                                           Category = g.Key,
            //                                                                           ProductCount = g.Count()
            //                                                                       });
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            #endregion



            #endregion

            #region LINQ - Ordering Operators



            #endregion

        }
    }
}
