using System;
using System.Diagnostics;

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

        public DateTime Date{get; set;}

    public Product(String Name , int Id , int Price, int Quant , DateTime Date, bool Iso)
    {
        this.Name =Name;
        this.Id=Id;
        this.Price=Price;
        this.Quant=Quant;
        this.Date=Date;
        this.Iso= Iso;
    }
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
            Date = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",null);
        }
        public void DisplayProductData()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Id: {Id}");
            Console.WriteLine($"Product Price: {Price}");
            Console.WriteLine($"Product Quantity: {Quant}");
            Console.WriteLine($"Product Iso standard check: {Iso}");
            Console.WriteLine($"Product expiry Date: {Date}");
        }

}

class Program
{
    static void Main(String[] args)
    {

        Product p1 = new Product("Laptop", 1, 50000, 2, DateTime.Now, true);
        p1.DisplayProductData();
    
    }
}