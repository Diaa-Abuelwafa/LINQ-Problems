using Day_01_G03;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using static Day_01_G03.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace Assignment02LINQ
{
    internal class Program
    {
        static void Main()
        {
            #region LINQ - Restriction Operators

            //// 1 - Find all products that are out of stock

            //var Result01 = ProductsList.Where(P => P.UnitsInStock == 0);

            //// 2 - Find all products that are in stock and cost more than 3.00 per unit

            //var Result02 = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //// 3 - Returns digits whose name is shorter than their value

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result03 = Arr.Where((N, i) => N.Length < i);

            #endregion

            #region LINQ - Element Operators

            //// 1 - Get first Product out of Stock

            //var Result01 = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0);

            //// 2 - Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var Result02 = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);

            //// 3 - Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result03 = Arr.First(N => N > 5);
            //var Result04 = Arr.First(N => N > 5 && N != Result03);

            //Console.WriteLine(Result03);
            //Console.WriteLine(Result04);

            #endregion

            #region LINQ - Aggregate Operators

            //// 1 - Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result01 = Arr.Where(N => N % 2 == 1).Count();

            //// 2 - Return a list of customers and how many orders each has

            //var Result02 = CustomersList.Select(C => new { Customer = C, Count = C.Orders.Count() });

            //// 3 -  Return a list of categories and how many products each has

            //var Temp = ProductsList.Select(P => P.Category).Distinct();
            //List<int> Temp2 = new List<int>();
            //for (int i = 0; i < Temp.Count(); ++i)
            //{
            //    Temp2.Add(ProductsList.Count(P => P.Category == Temp.ElementAt(i)));
            //}
            //var Result03 = Temp.Zip(Temp2, (C, I) => new { Category = C, Count = I });

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}

            //// 4 - Get the total of the numbers in an array

            //int[] Arr01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result04 = Arr01.Sum(N => N);

            //// 5 - Get the total number of characters of all words in dictionary_english.txt

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var Result05 = Words.Select(W => W.Length).Sum(W => W);

            //Console.WriteLine(Result05);

            //// 6 - Get the length of the shortest word in dictionary_english.txt

            //var Result06 = Words.Min(W => W.Length);

            //// 7 - Get the length of the longest word in dictionary_english.txt

            //var Result07 = Words.Max(W => W.Length);

            //// 8 -  Get the average length of the words in dictionary_english.txt 

            //var Result08 = Words.Select(W => W.Length).Average(W => W);

            //// 9 - Get the total units in stock for each product category

            //var Result09 = ProductsList.GroupBy(P => P.Category);

            //foreach (var Category in Result09)
            //{
            //    Console.WriteLine(Category.Key);
            //    Console.WriteLine(Category.Sum(C => C.UnitsInStock));
            //}

            //// 10 - Get the cheapest price among each category's products

            //var Result10 = ProductsList.GroupBy(P => P.Category);

            //foreach (var Category in Result10)
            //{
            //    Console.WriteLine(Category.Key);
            //    Console.WriteLine(Category.Min(C => C.UnitPrice));
            //}

            //// 11 - Get the products with the cheapest price in each category (Use Let)

            //var Result11 = from P in ProductsList
            //               where P.UnitPrice == (ProductsList.Min(P => P.UnitPrice))
            //               let N = P
            //               select N;

            //foreach (var item in Result11)
            //{
            //    Console.WriteLine(item);
            //}

            //// 12 -  Get the most expensive price among each category's products

            //var Result12 = ProductsList.GroupBy(P => P.Category);

            //foreach (var Category in Result12)
            //{
            //    Console.WriteLine(Category.Key);
            //    Console.WriteLine(Category.Max(C => C.UnitPrice));
            //}

            //// 13 - Get the products with the most expensive price in each category.

            //var Result13 = ProductsList.GroupBy(P => P.Category);
            //List<Product> TempList = new List<Product>();

            //foreach (var Category in Result13)
            //{
            //    var Result = Category.MinBy(C => C.UnitPrice);
            //    TempList.Add(Result);
            //}

            //// 14 - Get the average price of each category's products

            //var Result14 = ProductsList.GroupBy(P => P.Category);

            //foreach (var Category in Result14)
            //{
            //    Console.WriteLine(Category.Key);
            //    Console.WriteLine(Category.Average(C => C.UnitPrice));
            //}

            #endregion

            #region LINQ - Ordering Operators

            //// 1 - Sort a list of products by name

            //var Result01 = ProductsList.OrderBy(P => P.ProductName);

            //// 2 - Uses a custom comparer to do a case-insensitive sort of the words in an array

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result02 = Arr.OrderBy(N => N, StringComparer.OrdinalIgnoreCase);

            //// 3 - Sort a list of products by units in stock from highest to lowest

            //var Result03 = ProductsList.OrderByDescending(P => P.UnitsInStock);

            //// 4 - Sort a list of digits, first by length of their name, and then alphabetically by the name itself

            //string[] Arr01 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result04 = Arr01.OrderBy(N => N.Length).ThenBy(N => N);

            //// 5 - Sort first by-word length and then by a case-insensitive sort of the words in an array

            //string[] Arr02 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result05 = Arr02.OrderBy(N => N.Length).ThenBy(N => N, StringComparer.OrdinalIgnoreCase);

            //// 6 - Sort a list of products, first by category, and then by unit price, from highest to lowest

            //var Result06 = ProductsList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //// 7 - Sort first by-word length and then by a case-insensitive descending sort of the words in an array

            //string[] Arr03 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result07 = Arr03.OrderBy(N => N.Length).ThenByDescending(N => N, StringComparer.OrdinalIgnoreCase);

            //// 8 - Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array

            //string[] Arr04 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result08 = Arr04.Where(N => N[2] == 'i'); 

            #endregion

            #region LINQ – Transformation Operators

            //// 1 - Return a sequence of just the names of a list of products

            //var Result01 = ProductsList.Select(P => P.ProductName);

            //// 2 - Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types)

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result02 = words.Select(W => new { Upper = W.ToUpper(), Lower = W.ToLower() });

            //// 3 - Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type

            //var Result03 = ProductsList.Select(P => new { P.ProductID , P.Category , Price = P.UnitPrice});

            //// 4 - Determine if the value of int in an array match their position in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result04 = Arr.Select((N, i) => N == i);

            //foreach (var item in Result04)
            //{
            //    Console.WriteLine(item);
            //}

            //// 5 - Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //for(int i = 0; i < numbersA.Length; ++i)
            //{
            //    for(int j = 0; j < numbersB.Length; ++j)
            //    {
            //        if (numbersA[i] < numbersB[j])
            //        {
            //            Console.WriteLine($"{numbersA[i]} is less than {numbersB[j]}");
            //        }
            //    }
            //}

            //// 6 - Select all orders where the order total is less than 500.00

            //var Result06 = CustomersList.SelectMany(C => C.Orders).Where(C => C.Total < 500);

            //// 7 - Select all orders where the order was made in 1998 or later

            //var Result07 = CustomersList.SelectMany(C => C.Orders).Where(C => C.OrderDate < new DateTime(1, 1, 1980));


            #endregion

            #region LINQ - Set Operators

            //// 1 - Find the unique Category names from Product List

            //var Result01 = ProductsList.Select(P => P.Category).Distinct();

            //// 2 - Produce a Sequence containing the unique first letter from both product and customer names

            //var Temp1 = ProductsList.Select(P => P.ProductName[0]).Distinct();
            //var Temp2 = CustomersList.Select(C => C.CustomerName[0]).Distinct();

            //var Result02 = Temp1.Concat(Temp2);

            //// 3 - Create one sequence that contains the common first letter from both product and customer names

            //var Temp3 = ProductsList.Select(P => P.ProductName[0]).Distinct();
            //var Temp4 = CustomersList.Select(C => C.CustomerName[0]).Distinct();

            //var Result03 = Temp1.Intersect(Temp2);

            //// 4 - Create one sequence that contains the first letters of product names that are not also first letters of customer names

            //var Temp5 = ProductsList.Select(P => P.ProductName[0]).Distinct();
            //var Temp6 = CustomersList.Select(C => C.CustomerName[0]).Distinct();

            //var Result04 = Temp1.Except(Temp2);

            //// 5 - Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var Temp7 = ProductsList.Select(P => P.ProductName[^3]);
            //var Temp8 = CustomersList.Select(C => C.CustomerName[^3]);

            //var Result05 = Temp7.Concat(Temp8);
            #endregion

            #region LINQ - Partitioning Operators

            //// 1 - Get the first 3 orders from customers in Washington

            //var Result01 = CustomersList.Where(C => C.Address == "Washington").Take(3);

            //// 2 - Get all but the first 2 orders from customers in Washington

            //var Result02 = CustomersList.Where(C => C.Address == "Washington").Skip(2);

            //// 3 - Return elements starting from the beginning of the array until a number is hit that is less than its position in the array

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result03 = numbers.TakeWhile((N, i) => N > i);

            //// 4 - Get the elements of the array starting from the first element divisible by 3

            //int[] numbers01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result04 = numbers01.TakeWhile(N => N % 3 == 0);

            //// 5 -  Get the elements of the array starting from the first element less than its position

            //int[] numbers02 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result05 = numbers.TakeWhile((N, i) => N < i);
            #endregion

            #region LINQ - Quantifiers

            //// 1 - Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //bool Result01 = Words.Any(W => W.Contains("ei"));

            //// 2 - Return a grouped a list of products only for categories that have at least one product that is out of stock

            //var Result02 = ProductsList.GroupBy(P => P.Category);

            //foreach (var Category in Result02)
            //{
            //    var ResultTemp = Category.Count(C => C.UnitsInStock == 0);

            //    if(ResultTemp == 1)
            //    {
            //        Console.WriteLine(Category.Key);
            //    }
            //}

            //// 3 - Return a grouped a list of products only for categories that have all of their products in stock

            //var Result03 = ProductsList.GroupBy(P => P.Category);

            //foreach (var Category in Result02)
            //{
            //    var ResultTemp = Category.All(C => C.UnitsInStock == 0);

            //    if (ResultTemp == true)
            //    {
            //        Console.WriteLine(Category.Key);
            //    }
            //}

            #endregion

            #region LINQ – Grouping Operators

            //// 1 - Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result01 = numbers.GroupBy(N => N % 5);

            //foreach (var item in Result01)
            //{
            //    Console.WriteLine($"Numbers With A Remainder Of {item.Key} When Divide By 5");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            //// 2 - Uses group by to partition a list of words by their first letter.

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var Result02 = Words.GroupBy(W => W[0]);

            //// 3 - Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var Result03 = Arr.Select(W => new String(W.OrderBy(C => C).ToArray())).GroupBy(W => W);

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            #endregion
        }
    }
}
