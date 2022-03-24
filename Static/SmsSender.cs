using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Must be sent by Sms");
        }
    }
}
