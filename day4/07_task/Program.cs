namespace Task
{
    public abstract class OrderProcessor
    {
        public int OrderId{get; private set;}
        public int Amount{get; private set;}
        protected OrderProcessor(int OrderId, int Amount)
        {
            this.OrderId= OrderId;
            this.Amount=Amount;
        }
        public abstract void ProcessPayment();
        public abstract void GenerateInvoice();
        public abstract void SendNotification();

        public void DisplayOrderDetails()
        {
            Console.WriteLine(" Order ID : {0} \n Order Amount : {1}", OrderId, Amount);
        }
    }

    public class OnlineOrder: OrderProcessor
    {
        public OnlineOrder(int OrderId, int Amount) :base (OrderId, Amount){Console.WriteLine("THIS IS WHERE IT HAPPENSS");}
        public override void ProcessPayment()
        {
            Console.WriteLine("Online payment for Order has been processed");
        }
        public override void GenerateInvoice()
        {
            Console.WriteLine("Invoice for Order has been generated");
        }
        public override void SendNotification()
        {
            Console.WriteLine(" NOTIFICATION for Order has been processed");
        }
    }


    class Program
    {
        static void Main(String[] args)
        {
            OrderProcessor order1= new OnlineOrder(12,50000);
            // order1.OrderId= 123;
            // order1.Amount=50000;

            order1.DisplayOrderDetails();
            order1.ProcessPayment();
            order1.GenerateInvoice();
            order1.SendNotification();
        }
    }
}