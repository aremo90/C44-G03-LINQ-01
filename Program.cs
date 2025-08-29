using ConsoleApp1.Data;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

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

            #region 1. Sort a list of products by name

            //List<Product> products = ListGenerator.ProductList;
            //var result = products.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };



            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var result = ListGenerator.ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr
            //    .OrderBy(name => name.Length)
            //    .ThenBy(name => name);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(name => name.Length)
            //    .ThenBy(name => name, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ListGenerator.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(name => name.Length)
            //    .ThenByDescending(name => name, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr
            //    .Where(name => name.Length > 1 && name[1] == 'i')
            //    .OrderByDescending(name => Array.IndexOf(Arr, name));
            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var result = ListGenerator.ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ListGenerator.ProductList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    Price = p.UnitPrice
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((num, index) => new
            //{
            //    num,
            //    InPlace = (num == index)
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(a => numbersB,(a, b) => new { a, b }).Where(pair => pair.a < pair.b);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var result =ListGenerator.CustomerList
            //    .SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderID, o.Total })
            //    .Where(co => co.Total < 500.00M);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var result = ListGenerator.CustomerList
            //    .SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderID, o.OrderDate })
            //    .Where(co => co.OrderDate >= new DateTime(1998, 1, 1));

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

        }
    }
}
