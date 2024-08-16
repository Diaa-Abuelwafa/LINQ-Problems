using Day_01_G03;
using System.Collections;
using static Day_01_G03.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Filteration Operators

            //// Return Seq Contains The Products With UnitStock Equals 0
            //var Result01 = ProductsList.Where(P => P.UnitsInStock == 0);
            //var Result02 = ProductsList.Where(P => P.UnitsInStock == 0 && P.ProductID < 100);
            //// Indexed Where [Valid With Fluent Syntax Only]
            //var Result03 = ProductsList.Where((P, i) => P.UnitsInStock == 0 && i < 10);

            //// Query Expression
            //var Result04 = from P in ProductsList
            //               where P.UnitsInStock == 0
            //               select P;

            //// OfType Query Operator
            //// This Operator Using To Get Elements From Input Sequence With This Type

            //ArrayList List = new ArrayList() { "Diaa", 1, true, 1.5 };

            //var Result05 = List.OfType<string>(); // Return Diaa 

            #endregion

            #region Transformation Operators

            //// Transformation Each Element To New Element
            //// Mean New Sequence Contains Elements Of String
            //var Result01 = ProductsList.Select(P => P.ProductName);
            //var Result02 = ProductsList.Select(P => new { ID = P.ProductID, Name = P.ProductName });

            //// SelectMany
            //// When I Have A Input Sequenece And Each Element Is A Sequence 
            //// And A Need To Splited It To Elements Use SelectMany
            //// Outpust Sequence Larger Than Or Equal Input Sequence
            //var Result03 = ProductsList.SelectMany(P => P.ProductName.Split(' '));

            #endregion

            #region Ordering Operator

            //// OrderBy Is A Query Operator Than Take Input Sequence And Sort Them
            //// And Return The Sorted Sequence
            //// Default Ordering --> Ascending

            //var Result01 = ProductsList.OrderBy(P => P.ProductID);
            //var Result02 = Result01.Select(P => P.ProductName);

            //var Result03 = ProductsList.OrderByDescending(P => P.ProductID);
            //var Result04 = Result01.Select(P => P.ProductName);

            //var Result05 = ProductsList.OrderByDescending(P => P.ProductID).ThenBy(P => P.ProductName);
            //var Result06 = Result01.Select(P => P.ProductName);

            #endregion

            #region Elenemts Operators - Imidiate Execution

            //Product? P01 = ProductsList.First();
            //P01 = ProductsList.FirstOrDefault();

            //var Result01 = ProductsList.First(P => P.ProductID > 5);
            //Result01 = ProductsList.FirstOrDefault(P => P.ProductID > 5, new Product());

            //// 'Last' Same First

            //var Result02 = ProductsList.ElementAt(14);
            //Result02 = ProductsList.ElementAtOrDefault(14);

            //// Return Element If The Input Sequence Has One Element
            //var Result03 = ProductsList.Single();
            //// Return Element If The Input Sequence Has One Element And Return Null If No Elements
            //Result03 = ProductsList.SingleOrDefault();

            #endregion

            #region Aggregate Operators - Imidiate Execution

            //int Count = ProductsList.Count();
            //Count = ProductsList.Count(P => P.ProductID < 100);

            //var Sum = ProductsList.Sum(P => P.UnitPrice);
            //var Avg = ProductsList.Average(P => P.ProductID);

            //// Must The Input Sequence Implement The IComparable Interface To Make Compare Operation
            //var Result01 = ProductsList.Max();
            //// Return Value
            //var Result02 = ProductsList.Max(P => P.UnitPrice);
            //// If I Need To Return A Product Has A Max Price
            //var Result03 = ProductsList.MaxBy(P => P.UnitPrice);

            //// 'Min' Same 'Max'

            #endregion

            #region Casting Operator - Imidiate Execution

            //List<decimal> List = ProductsList.Select(P => P.UnitPrice).ToList();
            //Product[] Products = ProductsList.Select(P => P).ToArray();

            #endregion

            #region Generation Operators

            //// This Operators Has No Input Sequenece
            //// So I Must Call It Using The Class 

            //var Result01 = Enumerable.Range(0, 10); // 0..9
            //var Result02 = Enumerable.Repeat(ProductsList, 2);
            //var Result03 = Enumerable.Empty<int>();

            #endregion

            #region Set Operators

            //List<string> List1 = new List<string>() { "Ahmed", "Ali" };
            //List<string> List2 = new List<string>() { "Diaa", "Ehab", "Mohamed", "Abuelwafa" };

            //// Union --> Merge 2 Input Sequences In One Output Sequence Without Duplicated Elements 
            //var Result01 = List1.Union(List2);
            //// Concat --> Like Union But Without Removing Duplicated Elements
            //var Result02 = List1.Concat(List2);
            //// Except --> Return Elements In First Seq Not Exsits In Second
            //var Result03 = List1.Except(List2);
            //// Intersect --> Return The Common Elements In The 2 Input Sequences
            //var Result04 = List1.Intersect(List2);
            //// Distinct --> Return The Elements In The Input Sequences Not Duplicated
            //var Result0 = List1.Distinct();

            #endregion

            #region Quantifiers Operators

            // These Operators Return T or F

            //bool Result01 = ProductsList.Any();
            //bool Result02 = ProductsList.Any(P => P.UnitsInStock == 0);

            //bool Result03 = ProductsList.All(P => P.UnitsInStock == 0);

            //// Must Sequences Implement Interface Of Equality
            //List<Product> ListTemp = new List<Product>();
            //bool Result04 = ListTemp.SequenceEqual(ProductsList);

            //bool Result05 = ProductsList.Contains(new Product());

            #endregion

            #region Grouping Operator

            //// If I Have A Input Sequence And I Need To Divide It To Groups Of This InpuT Seq
            //// Based On Key

            //var Result01 = ProductsList.GroupBy(P => P.Category);
            //// I Have A Sequence Of Sequences And Each Seq Have A Key
            //foreach (var Category in Result01)
            //{
            //    Console.WriteLine(Category.Key);
            //}

            //// To Print The Products In Each Category
            //foreach (var Category in Result01)
            //{
            //    Console.WriteLine($"{Category.Key}");
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"..{Product.ProductName}");
            //    }
            //}

            #endregion

            #region Partitioning Operators

            //// Take , TakeLast , Skip , SkipLast , TakeWhile , SkipWhile

            //var Result01 = ProductsList.Take(5);
            //var Result02 = ProductsList.TakeLast(5);
            //var Result03 = ProductsList.Skip(5);
            //var Result04 = ProductsList.SkipLast(5);

            //var Result05 = ProductsList.TakeWhile(P => P.ProductName == "Diaa");
            //var Result06 = ProductsList.SkipWhile(P => P.ProductName == "Diaa");

            #endregion

            #region into - let

            //// into
            //// When I Write Query Expression
            //// And I Need To Put The Result Into Seq
            //// And Continue Quering

            //var Result01 = from P in ProductsList
            //               select P.ProductName
            //               into Temp
            //               where Temp.Length > 10
            //               select Temp;

            //// let
            //// When I Write Query Expression
            //// And I Need To Put The Result Into Seq
            //// And Continue Quering
            //// But I Need To Use Olso The Old Seq

            //var Result02 = from P in ProductsList
            //               let N = P.ProductName
            //               where N.Length > 10 && P.UnitPrice > 100
            //               select N;

            #endregion
        }
    }
}
