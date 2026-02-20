namespace UsingDelegate
{
     public delegate void NotificationSender(string message);

    class Notifier
    {

        public static void SendEmail(string message)
        {
            Console.WriteLine("MAIL SENT " + message);
        }
         public static void SendSMS(string message)
        {
            Console.WriteLine("SMS SENT " + message);
        }
         public static void SendPushNotification(string message)
        {
            Console.WriteLine("NOTIFICATION SENT " + message);
        }


    }
    class NotificationManager
    {
    
        public void NotifyUser(string message, NotificationSender sender)
        {
            sender(message); 
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            NotificationManager manager= new NotificationManager();

            manager.NotifyUser("Welcome User", Notifier.SendEmail);
            manager.NotifyUser("your otp is 1234", Notifier.SendSMS);
            manager.NotifyUser("New offer Available", Notifier.SendPushNotification);

        }
    }
}