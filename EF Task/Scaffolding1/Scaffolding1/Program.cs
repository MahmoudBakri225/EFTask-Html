using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Scaffolding1.Data;
using Scaffolding1.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Scaffolding1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            

            try
            {
                //Retrieve all categories from the production.categories table.
                /*var result = context.Categories.ToList();
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.CategoryId}, {item.CategoryName}");
                }*/


                // Retrieve the first product from the production.products table.
                /*var result = context.Products.First();
                Console.WriteLine($"{result.ProductId}, {result.ProductName},{result.BrandId},{result.CategoryId},{result.ModelYear},{result.ListPrice}")*/


                //Retrieve a specific product from the production.products table by ID.
                /* var result = context.Products.Find(1);
                 Console.WriteLine($"{result.ProductId}, {result.ProductName},{result.BrandId},{result.CategoryId},{result.ModelYear},{result.ListPrice}");

     */
                //Retrieve all products from the production.products table with a certain model year.
                /*var result = context.Products.Where(e => e.ModelYear >= 2016);
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.ProductId}, {item.ProductName},{item.BrandId},{item.CategoryId},{item.ModelYear},{item.ListPrice}");

                }*/



                //Retrieve a specific customer from the sales.customers table by ID.
                /*var result = context.Customers.Find(1);
                Console.WriteLine($"{result.CustomerId}, {result.FirstName},{result.LastName},{result.Phone}," +
                    $"{result.Email},{result.Street},{result.City},{result.State},{result.ZipCode}");
    */


                //Retrieve a list of product names and their corresponding brand names.
                /*var result = context.Products
                    .Select(e => new { e.ProductName, e.Brand.BrandName })
                    .ToList();

                foreach (var item in result)
                {
                    Console.WriteLine($"Product_Name:{item.ProductName}, Brand_Name:{item.BrandName}");
                }*/




                //Count the number of products in a specific category.
                /*var result = context.Products.Count();
                Console.WriteLine(result);*/



                //Calculate the total list price of all products in a specific category.
                /*var result = context.Products.Sum(e => e.ListPrice);
                  Console.WriteLine(result);*/


                // Calculate the average list price of products.
                /*var result = context.Products.Average(e => e.ListPrice);
                Console.WriteLine(result);*/



                //Retrieve orders that are completed.
                var result = context.Orders.Where(e => e.OrderStatus == 4).ToList();

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.OrderId}, {item.CustomerId},{item.OrderStatus},{item.OrderDate},{item.RequiredDate},{item.StoreId},{item.StaffId}");

                }
            }

            catch
            {
                Console.WriteLine("not found");
            }





        }
    }
}