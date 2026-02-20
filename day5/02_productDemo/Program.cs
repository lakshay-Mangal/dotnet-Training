using System.Diagnostics;

namespace ProductDemo
{
    public class Product
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Description{get; set;}
        public double Price{get; set;}
        public bool InStock{get; set;}
    }
    public class ProductCatalog
    {   
        private readonly List<Product> Products;
        public ProductCatalog()
        {
            // Products =
            // [
            //     new() {Id= 100, Name= "Laptop ", Description="It works ",Price=55000,InStock=true},
            //     new() {Id= 101, Name = "Mouse ",Description= " It also works ",Price= 800,InStock=false},
            //     new() {Id= 102, Name = "SmartPhone ",Description= " It sometimes works ",Price= 18000,InStock=true},
            //     new() {Id= 103, Name = "Desk ",Description= " It always works ",Price= 2800,InStock=true}
            // ];
            Products = new List<Product>();
            
        }
        public void AddProduct()
        {
            Product product = new();
            Console.WriteLine("Enter the id , name , description, price , stock availablitly of respectively ");
            product.Id= Convert.ToInt32(Console.ReadLine());
            product.Name = Console.ReadLine();
            product.Description= Console.ReadLine();
            product.Price= Convert.ToDouble(Console.ReadLine());
            product.InStock= Convert.ToBoolean(Console.ReadLine());
            
            // product= [prodId, name, description,price, InStock];   //wrong

            Products.Add(product);
        }
        public void DisplayProducts()
        {
            if(Products.Count==0) {Console.WriteLine("No products available"); return ;}

            foreach(var product in Products) {Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);
            Console.WriteLine();
            }

        }
        public void DeleteProduct()
        {
            if(Products.Count==0) {Console.WriteLine("No products available to delete"); return ;}
            Console.WriteLine("Enter product id");
            int id = int.Parse(Console.ReadLine());

            Product productToDelete = Products.FirstOrDefault(p=>p.Id==id);
            if(productToDelete ==null) {Console.WriteLine("Product not found"); return ;}
            Products.Remove(productToDelete);
            Console.WriteLine("Product deleted successfully");

        }


    }

    class TestProduct
    {
        static void Main(String[] args)
        {
            ProductCatalog c1=  new();
            int choice;
            do
            {
                Console.WriteLine("\n 1. Add Product");
                Console.WriteLine("2. Display Product");
                Console.WriteLine("3. Exit");
                Console.WriteLine("4. Delete");
                Console.WriteLine("\n Choose");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: c1.AddProduct();
                    break;
                    case 2: c1.DisplayProducts(); break;
                    case 3: Console.WriteLine("Exiting..........."); break;
                    case 4: c1.DeleteProduct(); break;
                    default: Console.WriteLine("Invalid Choice"); break;
                }

            } while(choice !=3);
        }
    }

}