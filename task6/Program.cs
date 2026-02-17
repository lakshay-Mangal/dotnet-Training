using System;
using System.Dynamic;
namespace ConsoleApp

{
    class Product
    {
        public string Name
        {
            get; 
            set;
        }
        public int Id
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public int Quant
        {
            get;
            set;
        }
        public bool Iso { get; set;}

        public DateTime Datexp{get; set;}
        public void GetProductData()
        {
            Console.WriteLine("Enter Product name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Product id:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Price:");
            Price= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity:");
            Quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product ISO Standard Check:");
            Iso = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Expiry Date:");
            Datexp = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",null);
        }
        public void DisplayProductData()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Id: {Id}");
            Console.WriteLine($"Product Price: {Price}");
            Console.WriteLine($"Product Quantity: {Quant}");
            Console.WriteLine($"Product Iso standard check: {Iso}");
            Console.WriteLine($"Product expiry Date: {Datexp}");
        }
    }
    class Program
{
    static void Main(String [] args)
    {
        Product p1 = new Product();
        p1.GetProductData();
        p1.DisplayProductData();
    }
}}