using inheritanceDemo;

namespace inheritanceDemo
{
    public class Person
    {
        private string name;
        private int age;

        public void GetInformation()
        {
            Console.WriteLine("Enter your Name and age");
            name= Console.ReadLine();
            age = int.Parse(Console.ReadLine());
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Your name is " +name + "\n your age is "+ age);
        }

    }
    public class Employee : Person
    {
        private string CompanyName;
        private int EmployeeID;
        private int EmployeeScore;
    
    public void GetEmpInfo()
        {
            Console.WriteLine("Enter your Company Name and Employee id  AND score respectively");
            CompanyName= Console.ReadLine();
            EmployeeID = int.Parse(Console.ReadLine());
            EmployeeScore = int.Parse(Console.ReadLine());

        }
        public void DisplayEmpInfo()
        {
            Console.WriteLine("Your Company name is " +CompanyName + "\n your ID is "+ EmployeeID);
            Console.WriteLine("Your Employee Score  is {0}", EmployeeScore);
        }
        public bool IsGoodEmployee()
        {
            return EmployeeScore >=76;
        }

    }
    interface IDepartment
    {
        string DepartName {get; set;}
        void DisplayDepartmentDetails();
    }
    public class GradeLevel : Employee, IDepartment
    {
            public string DepartName
        { get; set;
        }
        public void CheckEligible()
        {
            Console.WriteLine("Every employee should have score  above 75");
        }

        public void DisplayDepartmentDetails()
        {
            Console.WriteLine("Department Name: " +DepartName);
        }
    }
}


class Program :Person
{
    static void Main(String[] args)
    {
        // Person p1 = new ();
        // p1.GetInformation();
        // p1.DisplayInfo();
        Employee e1= new();

        // e1.GetInformation();
        // e1.DisplayInfo();
        // e1.GetEmpInfo();
        // e1.DisplayEmpInfo();
        // if(e1.IsGoodEmployee()) Console.WriteLine("Eligible for promotion");
        // else Console.WriteLine("Not eligible for promotion"); 

        GradeLevel g1 = new();

        g1.DepartName="HR";
        g1.DisplayDepartmentDetails();
    }
}