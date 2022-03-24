using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SmsSender sms = new SmsSender();
            EmailSender email = new EmailSender();
            Console.WriteLine("1. Send message by email");
            Console.WriteLine("2. Send message by sms");
            Console.WriteLine("0. Quit");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    email.SendMessage();
                    break;
                case 2:
                    sms.SendMessage();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("0,1,2 ededlerinden birini daxil edin");
                    break;
            }
        }
        
    }
}
