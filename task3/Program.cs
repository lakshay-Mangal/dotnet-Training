using System;
using System.Dynamic;
namespace ConsoleApp

{
    class Employee
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
        public string Department
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
        public string Position { get; set;}

        public DateTime JoinDate{get; set;}
        public void GetEmployeeData()
        {
            Console.WriteLine("Enter Employee name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee id:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Department:");
            Department= Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Position:");
            Position = Console.ReadLine();
            Console.WriteLine("Enter Employee Joining Date:");
            JoinDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",null);
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Department: {Department}");
            Console.WriteLine($"Employee Salary: {Salary}");
            Console.WriteLine($"Employee Position: {Position}");
            Console.WriteLine($"Employee Joining Date: {JoinDate}");
        }
    }
    class Program
{
    static void Main(String [] args)
    {
        Employee emp1 = new Employee();
        emp1.GetEmployeeData();
        emp1.DisplayEmployeeData();
    }
}}